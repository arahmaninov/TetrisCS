using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCS
{
    class Point
    {
        public int x;
        public int y;
        public char c;

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

        internal void Move(Direction dir)
        {
            switch(dir)
            {
                case Direction.DOWN:
                    y += 1;
                    break;
                case Direction.LEFT:
                    x -= 1;
                    break;
                case Direction.RIGHT:
                    x += 1;
                    break;
            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }
}
