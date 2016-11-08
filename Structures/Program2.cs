using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Föreläsning_5___structur
{
    struct Time
    {
        private int hours, minutes, seconds;

        public Time(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public override string ToString()
        {
            return string.Format("Aktuell tid = {0}:{1}:{2}", hours, minutes, seconds);
        }
    }

    class Program5
    {
        static void Main(string[] args)
        {

            Time tid = new Time(10, 6, 0);


            Console.WriteLine(tid.ToString());
            Console.ReadKey();


        }
    }
}
