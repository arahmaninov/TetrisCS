using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCS
{
    abstract class Figure
    {
        protected Point[] points = new Point[4];

        public void Draw()
        {
            foreach (Point p in points)
                p.Draw();
        }

        public void Move(Direction dir)
        {
            Hide();
            foreach (Point p in points)
                p.Move(dir);
            Draw();
        }

        public void Hide()
        {
            foreach (Point p in points)
                p.Hide();
        }

        public abstract void Rotate();
    }
}
