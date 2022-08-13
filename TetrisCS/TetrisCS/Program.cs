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
            Figure s;

            while(true)
            {
                FigureFall(out s, generator);
                s.Draw();
            }    

            static void FigureFall(out Figure s, FigureGenerator generator)
            {
                s = generator.GetNewFigure();
                s.Draw();

                for (int i = 0; i < 15; i++)
                {
                    s.Hide();
                    s.Move(Direction.DOWN);
                    s.Draw();
                    Thread.Sleep(200);
                }
            }

            Console.ReadLine();
        }
    }
}
