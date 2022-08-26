using System;
using System.Threading;

namespace TetrisCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(35, 40);
            Console.SetBufferSize(35, 40);

            FigureGenerator generator = new FigureGenerator(17, 0, '#');
            Figure currentFigure = generator.GetNewFigure();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    HandleKey(currentFigure, key);
                }
            }    


            Console.ReadLine();
        }

        private static void HandleKey(Figure currentFigure, ConsoleKeyInfo key)
        {
            switch(key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentFigure.Move(Direction.LEFT);
                    break;
                case ConsoleKey.RightArrow:
                    currentFigure.Move(Direction.RIGHT);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.Move(Direction.DOWN);
                    break;
            }
        }
    }
}
