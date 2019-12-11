using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public abstract class FigureFermee:Figure
    {
        public FigureFermee()
        {
            Console.WriteLine("fermee");
        }
        
        public abstract double GetSurface();
        public abstract double GetPerimetre();
    }
}
