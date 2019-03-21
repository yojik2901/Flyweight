using System;

namespace Flyweight
{
    public class Square : IShape
    {
        readonly int a = 10;

        public void draw(int x, int y)
        {
            Console.WriteLine("(" + x + " , " + y + ") : Рисуем квадрат со стороной = " + a);
        }
    }
}