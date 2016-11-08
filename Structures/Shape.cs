using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public abstract class Shape : IComparable<Shape>
    {
        private double _length;

        private double _width;

        private double _hypo;

        public Shape(double l, double w, double h) // constructor
        {
            _length = l;
            _width = w;
            _hypo = h;
        }

        public abstract double Area
        {
            get;
            

        }

        public abstract double Perimeter
        {
            get;


        }


        public double Length
        {
            get
            {
                return _length;
            }

            set
            {
                _length = value;
            }
        }


        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }
        public double Hypo
        {
            get
            {
                return _hypo;
            }

            set
            {
                _hypo = value;
            }
        }

        public override string ToString()
        {
            
            return ("Length: " + Length + "\n" + "Width: " + Width + "\n" + "Perimeter: " + Perimeter + "\n" + "Area: " + Area + "\n" + "Hypo: " + Hypo);
           
        }
        public int CompareTo(Shape other)
        {
            return Area.CompareTo(other.Area);
        }
    }
}
