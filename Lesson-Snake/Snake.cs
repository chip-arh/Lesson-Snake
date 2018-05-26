﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            pList = new List<Point>();
            direction = _direction;
            for (int i = 0; i<lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow) direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow) direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow) direction = Direction.DOWND;
            else if (key == ConsoleKey.UpArrow) direction = Direction.UP;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.isHit(food))
            {
                //food.sym = head.sym;
                //pList.Add(head);
                Move();
                return true;
            }
            else
                return false;
        }
    }
}
