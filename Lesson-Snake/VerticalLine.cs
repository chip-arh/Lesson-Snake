using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine( int yTop, int yButtom, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yButtom; y++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }
        
    }
}
