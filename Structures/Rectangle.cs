using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structures
{
    public class Rectangle : Shape
    {
        public Rectangle(double Length, double Width, double Hypo): base (Length, Width, Hypo)
        {         
        }

        public override double Perimeter //omkrets
        {
            get
            {
                return Length + Length + Width + Width;
            }  
        }

        public override double Area // area
        {
            get
            {
                return Length * Width;
            }

                  
        }

      
    }
}