using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yTop, int yButtom, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yButtom; y++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }
        public void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }
    }
}
