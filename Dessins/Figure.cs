using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public abstract class Figure
    {
        private string color;

        public string Color { get => color; set => color = value; }

        public abstract string Dessiner();
        public Figure()
        {
            Console.WriteLine("figure");

        }
    }
}
