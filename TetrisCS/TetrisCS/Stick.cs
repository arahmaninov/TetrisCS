using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisCS
{
    class Stick
    {
        Point[] points = new Point[4];

        public Stick(int x, int y, char symbol)
        {
            for(int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(x, y + i, '#');
            }
            /*points[0] = new Point(x, y, '#');
            points[0] = new Point(x, y, '#');
            points[0] = new Point(x, y, '#');
            points[0] = new Point(x, y, '#');*/
        }

        public void Draw()
        {
            foreach (Point p in points)
                p.Draw();
        }
    }
}
