using System;
using System.Collections.Generic;
using System.Text;

namespace Frog_TestTask
{
    class Frog
    {
        public Point CurrentPosition { get; set; }
        public Point Target { get; set; }
        public List<Point> TreePositions { get; set; }

        public Frog()
        {
            CurrentPosition = new Point 
            {
                Coordinate_X = 10,
                Coordinate_Y = 6
            };

            Target = new Point
            {
                Coordinate_X = 8,
                Coordinate_Y = 9
            };

            TreePositions = new List<Point>
            {
                new Point
                {
                    Coordinate_X = 4,
                    Coordinate_Y = 7
                },
                new Point
                {
                    Coordinate_X = 13,
                    Coordinate_Y = 8
                }
            };
        }

        public bool Move(Point moveTo)
        {
            if (moveTo.Coordinate_X >= 0 && moveTo.Coordinate_X <= 16 && moveTo.Coordinate_Y >= 0 && moveTo.Coordinate_Y <= 10 && 
                (moveTo.Coordinate_X == CurrentPosition.Coordinate_X + 3 && moveTo.Coordinate_Y == CurrentPosition.Coordinate_Y ||
                moveTo.Coordinate_X == CurrentPosition.Coordinate_X + 2 && moveTo.Coordinate_Y == CurrentPosition.Coordinate_Y - 1 ||
                moveTo.Coordinate_X == CurrentPosition.Coordinate_X + 2 && moveTo.Coordinate_Y == CurrentPosition.Coordinate_Y + 1 ||
                moveTo.Coordinate_X == CurrentPosition.Coordinate_X + 1 && moveTo.Coordinate_Y == CurrentPosition.Coordinate_Y - 2 ||
                moveTo.Coordinate_X == CurrentPosition.Coordinate_X + 1 && moveTo.Coordinate_Y == CurrentPosition.Coordinate_Y + 2))
            {
                CurrentPosition = moveTo;
                return true;
            }

            return false;
        }
    }
}
