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

            List<Point> pList = new List<Point>();
            pList.Add  ( p1 );
            pList.Add  ( p2 );

           

            
            Console.ReadLine();
        }
    }
}
