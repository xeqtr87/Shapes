using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structures
{
    public class Ellipse : Shape
    {
        public Ellipse(double length, double width, double Hypo): base(length, width, Hypo)
        {
            
            
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Math.Sqrt(((Length * Length)+(Width * Width)/2));
            }

           
        }

        public override double Area
        {
            get
            {
                return Length * Width * Math.PI;
            }

          
        }

       
    }
}