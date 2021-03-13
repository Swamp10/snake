using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            int x1 = 3;
            int y1 = 2;
            char sym1 = '*';
            **/
            Point p1 = new Point(3, 2, '*');
            p1.Draw();

            Point p2 = new Point(5, 4, '?');
            p2.Draw();
            Console.ReadLine();
        }
    }
}
