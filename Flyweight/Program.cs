using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            List<IShape> shapes = new List<IShape>();

            shapes.Add(shapeFactory.getShape("Square"));
            shapes.Add(shapeFactory.getShape("Circle"));
            shapes.Add(shapeFactory.getShape("Circle"));
            shapes.Add(shapeFactory.getShape("Point"));
            shapes.Add(shapeFactory.getShape("Square"));
            shapes.Add(shapeFactory.getShape("Circle"));

            Random rand = new Random();

            foreach (var shape in shapes)
            {
                int x = rand.Next(100);
                int y = rand.Next(100);
                shape.draw(x,y);
            }
        }
    }
}
