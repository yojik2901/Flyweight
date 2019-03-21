using System.Collections;
using System.Collections.Generic;

namespace Flyweight
{
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> _shapes = new Dictionary<string, IShape>();

        public IShape getShape(string shapeName)
        {
            IShape shape = null;
            if (!_shapes.TryGetValue(shapeName, out shape))
            {
                switch (shapeName)
                {
                    case "Circle":
                        shape = new Circle();
                        break;
                    case "Square":
                        shape = new Square();
                        break;
                    case "Point":
                        shape = new Point();
                        break;
                }

                _shapes[shapeName] = shape;
            }

            return shape;
        }
    }
}