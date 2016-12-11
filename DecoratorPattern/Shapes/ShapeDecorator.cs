using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Shapes
{
    public class ShapeDecorator:IShape
    {
        protected IShape Shape;

        public ShapeDecorator(IShape shape)
        {
            Shape = shape;
        }
        public virtual void Draw()
        {
            Shape.Draw();
        }

        public bool IsValid()
        {
            return Shape.IsValid();
        }
    }
}
