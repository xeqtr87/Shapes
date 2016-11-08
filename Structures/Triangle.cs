using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class Triangle : Shape
    {

        public Triangle (double length, double width, double Hypo) : base (length, width, Hypo)
        {

        }

        public override double Perimeter
        {
            get
            {
                return Length + Width + Hypo;
            }
        }
        public override double Area
        {
            get
            {
                return (Length * Width) / 2;
            }
        }
    }
}
