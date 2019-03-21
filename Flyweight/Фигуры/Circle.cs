using System;

namespace Flyweight
{
    public class Circle : IShape
    {
        readonly int r = 5;

        public void draw(int x, int y)
        {
            Console.WriteLine("(" + x + " , " + y + ") : Рисуем круг радиуса = " + r);
        }
    }
}