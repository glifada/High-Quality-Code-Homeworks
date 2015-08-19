using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    public class Directions
    {
        public int[] X = { 1, 1, 1, 0, -1, -1, -1, 0 };
        public int[] Y = { 1, 0, -1, -1, -1, 0, 1, 1 };

        public static void ChangeDirection(CurrentDirection currentDirection)
        {
            Directions direction = new Directions();
            int currentDirectionCount = 0;
            int DIRECTIONS_COUNT = 8;

            for (int i = 0; i < DIRECTIONS_COUNT; i++)
            {
                if (direction.X[i] == currentDirection.X && direction.Y[i] == currentDirection.Y)
                {
                    currentDirectionCount = i;
                    break;
                }
            }

            if (currentDirectionCount == (DIRECTIONS_COUNT - 1))
            {
                currentDirection.X = direction.X[0];
                currentDirection.Y = direction.Y[0];
                return;
            }

            currentDirection.X = direction.X[currentDirectionCount + 1];
            currentDirection.Y = direction.Y[currentDirectionCount + 1];
        }
    }
}
