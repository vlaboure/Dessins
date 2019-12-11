using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public class Cercle : FigureFermee
    {
        private Point centre;
        private double rayon;
        public Cercle(Point c, Double r)
        {
            Color = "blue";
            centre = c;
            rayon = r;
        }
        public override string Dessiner()
        {
            string res = "";
            res += "Cercle centre : (" + centre.X + "," + centre.Y + ")\n" +
                "Rayon : (" +rayon + ")";
            return res;
        }

        public override double GetPerimetre()
        {
            return Math.Round(2 *Math.PI*rayon,2);
        }

        public override double GetSurface()
        {
            return Math.Round(Math.PI * rayon * rayon,2);
        }
    }
}
