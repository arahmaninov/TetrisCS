using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCS
{
    class Stick : Figure
    {
        public Stick(int x, int y, char symbol)
        {
            for(int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(x, y + i, '#');
            }
        }

        public override void Rotate()
        {
            if (points[0].x == points[1].x)
                RotateHorizontal();
            else
                RotateVertical();
        }

        private void RotateHorizontal()
        {
            for(int i = 0; i < points.Length; i++)
            {
                points[i].y = points[0].y;
                points[i].x = points[0].x + i;
            }
        }
        private void RotateVertical()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = points[0].x;
                points[i].y = points[0].y + i;
            }
        }
    }
}
