using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Shapes
{
    public class Line : IShape
    {
        private Point pt1;
        private Point pt2;
        public Line(Point pt1, Point pt2)
        {
            this.pt1 = pt1;
            this.pt2 = pt2;
        }
        public void Draw()
        {
            string outPutLine = string.Format("Line drawn. Points: ({0},{1}) ({2},{3})", pt1.x, pt1.y, pt2.x, pt2.y);
            Console.WriteLine(outPutLine);
        }

        public bool IsValid()
        {
            //same point
            if(pt1==null && pt2==null || (pt1.x==pt2.x && pt1.y==pt2.y))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
