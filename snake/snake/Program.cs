using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,4,'*');
             p1.Drow();

            Point p2 = new Point(2,6,'$');
             p2.Drow();

            Goriz_lin line = new Goriz_lin(5,10,5,'+');
            line.Drow();

            Wert_lin line1 = new Wert_lin(5, 10, 5, '+');
            line1.Drow();

            Console.ReadLine();
        }
    }
}
