using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TetrisCS
{
    class Point
    {
        int x;
        int y;
        char c;

        public Point(int a, int b, char symbol)
        {
            x = a;
            y = b;
            c = symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
