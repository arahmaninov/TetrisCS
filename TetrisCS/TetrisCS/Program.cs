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

            Point[] points = new Point[3];
            points[0] = new Point(16, 5, '#');
            points[1] = new Point(18, 8, '#');
            points[2] = new Point(20, 11, '#');
            foreach (Point p in points)
                p.Draw();

            Square sq1 = new Square(8, 20, '#');
            sq1.Draw();

            Stick s1 = new Stick(12, 20, '#');
            s1.Draw();

            /*char[][] field = new char[3][];
            field[0] = new char[3];
            field[1] = new char[3];
            field[2] = new char[3];
            field[0][0] = 'X';
            field[2][2] = 'O';
            for(int i = 0; i < field.Length; i++)
            {
                for(int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }*/

            Console.ReadLine();
        }
    }
}
