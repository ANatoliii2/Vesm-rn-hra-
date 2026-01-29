using System;
using System.Collections.Generic;

namespace VesmirnaHra
{
    //tu je Zapozdření(private set) 
    public class Logika
    {
        public Raketa Hrac { get; private set; }
        public List<Kamen> Kameny { get; private set; }
        public int Skore { get; private set; }
        public bool Konec { get; private set; }
        private Random nahoda;

        public Logika()
        {
            nahoda = new Random();
            Start();
        }

        public void Start()
        {
            Hrac = new Raketa(Nastaveni.Sirka / 2, Nastaveni.Vyska - 80);
            Kameny = new List<Kamen>();
            Skore = 0;
            Konec = false;
        }

        public void Hraj()
        {
            if (Konec) return;

            if (nahoda.Next(0, 20) == 0)
            {
                Kameny.Add(new Kamen(nahoda.Next(0, Nastaveni.Sirka - Nastaveni.Velikost), -30));
            }

            for (int i = Kameny.Count - 1; i >= 0; i--)
            {
                Kameny[i].Pohyb();
                if (Kameny[i].DejObdelnik().IntersectsWith(Hrac.DejObdelnik())) Konec = true;
                if (Kameny[i].JePryc()) { Kameny.RemoveAt(i); Skore++; }
            }
        }
    }
}