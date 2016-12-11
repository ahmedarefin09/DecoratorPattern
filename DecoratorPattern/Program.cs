using DecoratorPattern.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pt1 = new Point(0, 0);
            Point pt2 = new Point(2, 0);
            Point pt3 = new Point(2, 2);
            Point pt4 = new Point(0, 2);

            IShape line = new Line(pt1, pt2);
            if (line.IsValid())
                line.Draw();

            RedShapeDecorator redShapeDecorator = new RedShapeDecorator(new Line(pt1, pt2));
            if (redShapeDecorator.IsValid())
                redShapeDecorator.Draw();

            IShape rectangle = new Rectangle(pt1, pt2, pt3, pt4);
            if (rectangle.IsValid())
                rectangle.Draw();

            redShapeDecorator = new RedShapeDecorator(new Rectangle(pt1, pt2, pt3, pt4));
            if (redShapeDecorator.IsValid())
                redShapeDecorator.Draw();
        }
    }
}
