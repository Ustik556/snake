using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Wert_lin
    {
        List<Point> pList;

        public Wert_lin(int Lefty, int Rihy, int x, char sim)
        {
            pList = new List<Point>();
            for(int y =Lefty;y<=Rihy; y++)
            {
                Point p = new Point(x, y, sim);
                pList.Add(p);
            }
        }
        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Drow();
            }
        }

    }
}
