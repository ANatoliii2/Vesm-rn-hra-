using System;
using System.Drawing;
using System.Windows.Forms;

namespace VesmirnaHra
{
    public partial class Form1 : Form
    {
        private Logika hra;
        private Timer timer1;

        public Form1()
        {
            InitializeComponent();

            this.Width = Nastaveni.Sirka;
            this.Height = Nastaveni.Vyska;
            this.Text = "Semestrální projekt";
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            hra = new Logika();

            timer1 = new Timer();
            timer1.Interval = Nastaveni.RychlostHry;
            timer1.Tick += Timer_Tik;
            timer1.Start();

            this.KeyDown += Klavesa;
            this.Paint += Vykresleni;
        }

        private void Timer_Tik(object sender, EventArgs e)
        {
            if (hra.Konec)
            {
                timer1.Stop();
                MessageBox.Show("Konec hry! Body: " + hra.Skore);
                hra.Start();
                timer1.Start();
            }
            else
            {
                hra.Hraj();
                this.Text = "Body: " + hra.Skore;
                this.Invalidate();
            }
        }

        private void Vykresleni(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Brush b = new SolidBrush(hra.Hrac.Barva))
            {
                g.FillRectangle(b, hra.Hrac.X, hra.Hrac.Y, Nastaveni.Velikost, Nastaveni.Velikost);
            }

            foreach (var k in hra.Kameny)
            {
                using (Brush b = new SolidBrush(k.Barva))
                {
                    g.FillRectangle(b, k.X, k.Y, Nastaveni.Velikost, Nastaveni.Velikost);
                }
            }
        }

        private void Klavesa(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) hra.Hrac.Doleva();
            if (e.KeyCode == Keys.Right) hra.Hrac.Doprava();
        }
    }
}