using System.Drawing;

namespace VesmirnaHra
{
    //Označení Rodiče ( abstraktní třida)
    public abstract class ObjektHry
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public Color Barva { get; protected set; }

        public ObjektHry(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract void Pohyb();

        public Rectangle DejObdelnik()
        {
            return new Rectangle(X, Y, Nastaveni.Velikost, Nastaveni.Velikost);
        }
    }
}