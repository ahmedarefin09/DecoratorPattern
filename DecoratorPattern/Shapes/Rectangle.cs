using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Shapes
{
    public class Rectangle : IShape
    {
        private Point pt1;
        private Point pt2;
        private Point pt3;
        private Point pt4;

        public Rectangle(Point pt1,Point pt2,Point pt3,Point pt4)
        {
            this.pt1 = pt1;
            this.pt2 = pt2;
            this.pt3 = pt3;
            this.pt4 = pt4;
        }

        public void Draw()
        {
            string outPutLine = string.Format("Rectangle drawn. Points: ({0},{1}) ({2},{3}) ({4},{5}) ({6},{7})", pt1.x, pt1.y, pt2.x, pt2.y, pt3.x, pt3.y, pt4.x, pt4.y);
            Console.WriteLine(outPutLine);
        }

        public bool IsValid()
        {
            double cx, cy;
            double dd1, dd2, dd3, dd4;

            cx = (pt1.x + pt2.x + pt3.x + pt4.x) / 4;
            cy = (pt1.y + pt2.y + pt3.y + pt4.y) / 4;

            dd1 = Math.Pow((cx - pt1.x),2) + Math.Pow((cy - pt1.y), 2);
            dd2 = Math.Pow((cx - pt2.x), 2) + Math.Pow((cy - pt2.y), 2); ;
            dd3 = Math.Pow((cx - pt3.x), 2) + Math.Pow((cy - pt3.y), 2); ;
            dd4 = Math.Pow((cx - pt4.x), 2) + Math.Pow((cy - pt4.y), 2); ;
            return dd1 == dd2 && dd1 == dd3 && dd1 == dd4;
        }
    }
}
