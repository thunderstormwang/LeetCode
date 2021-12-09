using System;

namespace LeetCode.Solution0201_9999
{
    public class Solution0670
    {
        public int MaximumSwap(int num)
        {
            var str = num.ToString();
            var rightTopIndex = -1;
            for (var i = str.Length - 1; i > 0; i--)
            {
                if (str[i] - str[i - 1] <= 0)
                {
                    continue;
                }

                if (rightTopIndex == -1)
                {
                    rightTopIndex = i;
                }
                else
                {
                    if (str[i] > str[rightTopIndex])
                    {
                        rightTopIndex = i;
                    }
                }
            }

            if (rightTopIndex == -1)
            {
                return num;
            }

            while (rightTopIndex < str.Length - 1 && str[rightTopIndex] == str[rightTopIndex + 1])
            {
                rightTopIndex++;
            }

            for (var i = 0; i < rightTopIndex; i++)
            {
                if (str[i] >= str[rightTopIndex])
                {
                    continue;
                }

                var temp = str[i];
                str = str.Insert(i + 1,
                    str[rightTopIndex].ToString()).Remove(i,
                    1);
                str = str.Insert(rightTopIndex + 1,
                    temp.ToString()).Remove(rightTopIndex,
                    1);
                break;
            }

            return Convert.ToInt32(str);
        }
    }

    // 從右往左找最高點
    // 如果一個高點都沒找到, 代表數字已從大排到小, 沒有交換的必要
    // 如果有最高點, 從左邊開始找比最高點小的數字並作交換

    // Time: O(N)
    // Space: O(1)
}