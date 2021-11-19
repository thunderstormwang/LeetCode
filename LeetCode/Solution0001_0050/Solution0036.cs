using System;
using System.Collections.Generic;

namespace LeetCode.Solution0001_0050
{
    public class Solution0036
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (var i = 0; i < board.Length; i++)
            {
                var used = new HashSet<char>();
                for (var j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != '.' && !used.Add(board[i][j]))
                    {
                        return false;
                    }
                }
            }

            Console.WriteLine("Row");

            for (var j = 0; j < board[0].Length; j++)
            {
                var used = new HashSet<char>();
                for (var i = 0; i < board.Length; i++)
                {
                    if (board[i][j] != '.' && !used.Add(board[i][j]))
                    {
                        return false;
                    }
                }
            }

            Console.WriteLine("Column");

            var xList = new List<int>() { 0, 0, 0, 1, 1, 1, -1, -1, -1 };
            var yList = new List<int>() { 0, 1, -1, 0, 1, -1, 0, 1, -1 };

            for (var i = 1; i < board.Length; i += 3)
            {
                for (var j = 1; j < board[i].Length; j += 3)
                {
                    var used = new HashSet<char>();
                    for (int k = 0; k < xList.Count; k++)
                    {
                        var target = board[i + xList[k]][j + yList[k]];
                        if (target != '.' && !used.Add(target))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
        
        // Time: O(1)
        // Space: O(1)
    }
}