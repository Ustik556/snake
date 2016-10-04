using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Goriz_lin
    {
        List<Point> pList;

          public Goriz_lin( int xLeft, int xRighte, int y, char sim)
        {
            pList = new List<Point>();

            for (int x = xLeft; x <= xRighte; x++) 
            {
                Point p = new Point( x, y, sim);
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
