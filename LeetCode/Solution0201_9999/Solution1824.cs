using System;

namespace LeetCode.Solution0201_9999
{
    public class Solution1824
    {
        public int MinSideJumps(int[] obstacles)
        {
            var array = new int [obstacles.Length][];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new int [3];
            }

            array[0][1] = 0;
            array[0][0] = 1;
            array[0][2] = 1;

            for (var i = 1; i < obstacles.Length; i++)
            {
                for (var k = 0; k < 3; k++)
                {
                    if (obstacles[i - 1] == (k + 1) || obstacles[i] == (k + 1))
                    {
                        array[i][k] = 99;
                    }
                    else
                    {
                        var aLane = (k + 1) % 3;
                        var bLane = (k + 2) % 3;
                        array[i][k] = Math.Min(array[i - 1][k],
                            Math.Min(array[i - 1][aLane],
                                array[i - 1][bLane]) + 1);
                    }
                }
            }

            return Math.Min(array[obstacles.Length - 1][0],
                Math.Min(array[obstacles.Length - 1][1],
                    array[obstacles.Length - 1][2]));
        }
        
        // https://www.youtube.com/watch?v=6-49f0eystc
        // ??
    }
}