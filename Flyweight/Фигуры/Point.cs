using System;

namespace Flyweight
{
    public class Point : IShape
    {
        public void draw(int x, int y)
        {
            Console.WriteLine("(" + x + " , " + y + ") : Рисуем точку");
        }
    }
}