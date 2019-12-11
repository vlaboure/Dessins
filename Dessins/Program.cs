using metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessins
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureOuverte fOv = new FigureOuverte();
            Console.WriteLine(fOv.Dessiner() + "\n********\n couleur " + fOv.Color);
            Console.ReadLine();
            Point p1 = new Point(50, 30);
            Point p2 = new Point(250, 130);
            Rectangle rec = new Rectangle(p1, p2);
            Console.WriteLine(rec.Dessiner()+ "\n********\n couleur " + rec.Color );
            Console.WriteLine("Perimètre : "+ rec.GetPerimetre());
            Console.WriteLine("Surface : " + rec.GetSurface());
            Console.ReadLine();
            Point centre = new Point(60, 40);
            int rayon = 80;
            Cercle monCercle = new Cercle(centre, rayon);
            Console.WriteLine(monCercle.Dessiner() + "\n********\n couleur " + monCercle.Color);
            Console.WriteLine("Perimètre : " + monCercle.GetPerimetre());
            Console.WriteLine("Surface : " + monCercle.GetSurface());
            Console.ReadLine();
        }
    }
}
