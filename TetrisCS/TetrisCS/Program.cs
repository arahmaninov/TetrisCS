using System;

namespace TetrisCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(35, 40);
            Console.SetBufferSize(35, 40);

            Point p1 = new Point(2, 4, '@');
            p1.Draw();

            Point p2 = new Point(8, 14, '^');
            p2.Draw();

            Console.ReadLine();
        }
    }
}
