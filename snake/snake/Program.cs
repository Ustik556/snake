using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Goriz_lin Up = new Goriz_lin(0,78,0,'+');
            Up.Drow();
            Goriz_lin Down = new Goriz_lin(0, 78, 24, '+');
            Down.Drow();
            Wert_lin Left = new Wert_lin(0, 24, 0, '+');
            Left.Drow();
            Wert_lin Righte = new Wert_lin(0, 24, 78, '+');
            Righte.Drow();

            Point p = new Point(4, 4, '#');
            Snake snake = new Snake(p, 3, direction.Right);
            snake.Drow();
            for (int i = 0; i <= 50; i++)
            {
                snake.Move();
                Thread.Sleep(200);
            }
            Console.ReadLine();
        }
    }
}
