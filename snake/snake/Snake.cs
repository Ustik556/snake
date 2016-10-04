using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake: Figur
    {
        direction Direction;
        public Snake(Point tals, int lenght, direction direction)
        {
            Direction = direction;
            pList = new List<Point>();
            for (int i = 0; i <= lenght; i++)
            {
                Point p = new Point(tals);
                p.Move(i, direction);
                pList.Add(p);

            }
        }

        internal void Move()
        {
            Point tals = pList.First();
            pList.Remove(tals);
            Point head = GetNextPoint();
            pList.Add(head);

            tals.Clear();
            head.Drow();
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextpoint = new Point(head);
            nextpoint.Move(1, Direction);
            return nextpoint;
        }
    }
}
