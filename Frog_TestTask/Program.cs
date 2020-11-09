using System;
using System.Collections.Generic;
using System.Linq;

namespace Frog_TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var treePositions = new List<Point>
            {
                new Point
                {
                    Coordinate_X = 5,
                    Coordinate_Y = 8
                },
                new Point
                {
                    Coordinate_X = 14,
                    Coordinate_Y = 9
                }
            };

            var target = new Point
            {
                Coordinate_X = 9,
                Coordinate_Y = 10
            };

            var frog = new Frog(); 

            var arr = GenerateArr(treePositions, target, frog);
            ShowArr(arr);

            Console.ReadKey();
        }

        public static int FindShortestWay(List<Point> treePositions, Point target, Frog frog)
        {
            var currentPosition = new Point 
            { 
                Coordinate_X = frog.CurrentPosition.Coordinate_X,
                Coordinate_Y = frog.CurrentPosition.Coordinate_Y
            };

            var wayToTargetByXcoordinate = 0;
            var wayToTargetByYcoordinate = 0;

            if (currentPosition.Coordinate_X > target.Coordinate_X)
            {
                wayToTargetByXcoordinate = 16 - currentPosition.Coordinate_X + target.Coordinate_X;
                
            }
            if (currentPosition.Coordinate_X < target.Coordinate_X)
            {
                wayToTargetByXcoordinate = currentPosition.Coordinate_X - target.Coordinate_X;
            }
            if (currentPosition.Coordinate_Y > target.Coordinate_Y)
            {
                wayToTargetByYcoordinate = currentPosition.Coordinate_Y - target.Coordinate_Y;
            }
            if (currentPosition.Coordinate_Y < target.Coordinate_Y)
            {
                wayToTargetByYcoordinate = target.Coordinate_Y - currentPosition.Coordinate_Y;
            }







            return 0;
        }

        public static string[][] GenerateArr(List<Point> treePositions, Point target, Frog frog)
        {
            var arr = new string[10][];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new string[16];

                for (int j = 0; j < arr[i].Length; j++)
                {

                    if (treePositions.Any(p => p.Coordinate_X - 1 == j && p.Coordinate_Y - 1 == i))
                    {
                        arr[i][j] = "T";
                    }
                    else if (j == target.Coordinate_X - 1 && i == target.Coordinate_Y - 1)
                    {
                        arr[i][j] = "*";
                    }
                    else if (j == frog.CurrentPosition.Coordinate_X - 1 && i == frog.CurrentPosition.Coordinate_Y - 1)
                    {
                        arr[i][j] = "F";
                    }
                    else
                    {
                        arr[i][j] = "_";
                    }
                }
            }

            return arr;
        }

        public static void ShowArr(string[][] arr)
        {
            foreach (var row in arr)
            {
                foreach (var item in row)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
            }
        }
    }
}
