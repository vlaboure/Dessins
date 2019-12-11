using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public class Rectangle : FigureFermee
    {
        private int longueur, larg;
        private Point ptHautG;
        private Point ptBasD;

        public Rectangle(Point p1, Point p2)
        {
            ptHautG = p1;
            ptBasD = p2;
            Color = "yellow";
            longueur = GetLongLarg(ptHautG.X, ptBasD.X);
            larg = GetLongLarg(ptHautG.Y, ptBasD.Y);
        }
        public override string Dessiner()
        {
            string res = "";
            res += "Rectangle point haut/gauche : (" + ptHautG.X + "," + ptHautG.Y + ")\n" +
                "point bas droit : (" + ptBasD.X + "," + ptBasD.Y + ")";
            return res;
        }
        private int GetLongLarg(int x1,int x2)
        {
            return Math.Abs(x1 - x2);
        }
        public override double GetPerimetre()
        { 
            return 2 * (longueur + larg);
        }

        public override double GetSurface()
        {
            return longueur * larg;
        }
    }
}
