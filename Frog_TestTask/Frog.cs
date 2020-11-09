using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frog_TestTask
{
    class Frog
    {
        public Point CurrentPosition { get; set; }
        //public Point Target { get; set; }
        //public List<Point> TreePositions { get; set; }

        public Frog()
        {
            CurrentPosition = new Point 
            {
                Coordinate_X = 11,
                Coordinate_Y = 7
            };

            //Target = new Point
            //{
            //    Coordinate_X = 8,
            //    Coordinate_Y = 9
            //};

            //TreePositions = new List<Point>
            //{
            //    new Point
            //    {
            //        Coordinate_X = 4,
            //        Coordinate_Y = 7
            //    },
            //    new Point
            //    {
            //        Coordinate_X = 13,
            //        Coordinate_Y = 8
            //    }
            //};
        }

        //public bool Move(Point moveTo)
        //{
        //    var canMove = moveTo.Coordinate_X >= 0
        //                  && moveTo.Coordinate_X <= 16
        //                  && moveTo.Coordinate_Y >= 0
        //                  && moveTo.Coordinate_Y <= 10
        //                  && TreePositions.All(p => p.Coordinate_X != moveTo.Coordinate_X && p.Coordinate_Y != moveTo.Coordinate_Y);

        //    if (!canMove)
        //    {
        //        return false;
        //    }

        //    var differenceBetweenXCoordinates = 0;
        //    var newXCoordinateShouldBe = CurrentPosition.Coordinate_X;

        //    // Defining the difference between old and new X coordinate
        //    if (moveTo.Coordinate_Y == CurrentPosition.Coordinate_Y)
        //    {
        //        differenceBetweenXCoordinates = 3;
        //    }
        //    else if (moveTo.Coordinate_Y == CurrentPosition.Coordinate_Y + 1 ||
        //            moveTo.Coordinate_Y == CurrentPosition.Coordinate_Y - 1)
        //    {
        //        differenceBetweenXCoordinates = 2;
        //    }
        //    else if (moveTo.Coordinate_Y == CurrentPosition.Coordinate_Y + 2 ||
        //            moveTo.Coordinate_Y == CurrentPosition.Coordinate_Y - 2)
        //    {
        //        differenceBetweenXCoordinates = 1;
        //    }

        //    // Defining what new X coordinate should be
        //    for (int i = 0; i < differenceBetweenXCoordinates; i++)
        //    {
        //        newXCoordinateShouldBe++;

        //        if (newXCoordinateShouldBe > 16)
        //        {
        //            newXCoordinateShouldBe = 1;
        //        }
        //    }

        //    if (canMove && differenceBetweenXCoordinates != 0 && 
        //        moveTo.Coordinate_X == newXCoordinateShouldBe)
        //    {
        //        CurrentPosition = moveTo;
        //        return true;
        //    }           

        //    return false;
        //}
    }
}
