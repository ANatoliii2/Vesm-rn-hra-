using System;
using System.Drawing;

namespace VesmirnaHra
{
    //Označení potomka ( Dedičnost)
    public class Raketa : ObjektHry
    {
        public Raketa(int x, int y) : base(x, y)
        {
            Barva = Color.Blue;
        }

        //tu dole mam polymorfismus 
        public override void Pohyb() { }

        public void Doleva()
        {
            if (X > 0) X -= Nastaveni.RychlostRakety;
        }

        public void Doprava()
        {
            if (X < Nastaveni.Sirka - Nastaveni.Velikost - 15) X += Nastaveni.RychlostRakety;
        }
    }

    public class Kamen : ObjektHry
    {
        public Kamen(int x, int y) : base(x, y)
        {
            Barva = Color.Red;
        }

        public override void Pohyb()
        {
            Y += Nastaveni.RychlostKamene;
        }

        public bool JePryc()
        {
            return Y > Nastaveni.Vyska;
        }
    }
}