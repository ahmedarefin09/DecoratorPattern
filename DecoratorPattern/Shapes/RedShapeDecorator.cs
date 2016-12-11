using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Shapes
{
    public class RedShapeDecorator:ShapeDecorator
    {
        public RedShapeDecorator(IShape Shape) : base(Shape)
        {
        }
            
        override  
        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Shape.Draw();
            setRedBorder();
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void setRedBorder()
        {
            Console.WriteLine("Border Color: Red");
        }
    }
    
}
