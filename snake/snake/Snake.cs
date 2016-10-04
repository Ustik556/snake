using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake: Figur
    { 
        
        public Snake(Point tals, int lenght, direction direction)
        {
            pList = new List<Point>();
            for (int i = 0; i <= lenght; i++)
            {
                Point p = new Point(tals);
                p.Move(i, direction);
                pList.Add(p);

            }
        }
    }
}
