using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sim;

        public Point(int _x, int _y, char _sim)
        {
            x = _x;
            y = _y;
            sim = _sim;
        }

        public void Drow()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sim);
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sim = p.sim;

        }
        public void Clear()
        {
            sim = ' ';
            Drow();

        }
        public void Move(int offset, direction Direction)
        {
         if(Direction == direction.Right)
            {
                x = x + offset;
            } else if (Direction == direction.Left)
            {
                x = x - offset;
            }
            else if (Direction == direction.Up)
            {
                y = y - offset;
            }
            else if (Direction == direction.Down)
            {
                y = y + offset;
            }
        }
    }
}
