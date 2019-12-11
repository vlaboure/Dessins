using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public sealed class FigureOuverte :Figure   
    {
        private Point[] points;
        public FigureOuverte()
        {
            points = new Point[10]; 
            for (int i=0; i < points.Length; i++)
            {//sortie des points
                points[i] = SortPoint();
            }
        }

        public override string Dessiner()
        {
            string res = "";
            for(int i=0;i<points.Length;i++)
            {
                res += "point " + (i + 1) + " : (" + points[i].X + "," + points[i].Y + ")\n";
            }
            return res;
        }

        private Point SortPoint()
        {
 
            Random aleat = new Random();
            int x = aleat.Next(0, 800);
            int y = aleat.Next(0, 800);
            Point p = new Point(x, y);
            return p;
        }
        


    }
}
