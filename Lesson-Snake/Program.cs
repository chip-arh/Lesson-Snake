using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorisontalLine upline = new HorisontalLine(0,78,0,'+');
            HorisontalLine downline = new HorisontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

            Console.ReadLine();
        }

        
    }
}
