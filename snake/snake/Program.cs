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
            Point p1 = new Point();
             p1.x = 1;
             p1.y = 4;
             p1.sim = '*';
             p1.Drow();

            Point p2 = new Point();
             p2.x = 2;
             p2.y = 6;
             p2.sim = '$';
             p2.Drow();


            Console.ReadLine();
        }
    }
}
