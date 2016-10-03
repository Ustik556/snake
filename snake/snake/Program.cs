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
            int x1 = 1;
            int y1 = 4;
            char sim1 = '*';
            Drow(x1, y1, sim1);

            int x2 = 2;
            int y2 = 5;
            char sim2 = '$';
            Drow(x2, y2, sim2);

            Console.ReadLine();
        }
        static void Drow(int x, int y, char sim)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }
    }
}
