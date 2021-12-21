using System;
using System.Linq;

namespace LeetCode.Solution0501_9999
{
    public class Solution0670
    {
        public int MaximumSwap_Version1(int num)
        {
            var charArray = num.ToString().ToArray();
            var rightTopIndex = -1;
            for (var i = charArray.Length - 1; i > 0; i--)
            {
                if (charArray[i] - charArray[i - 1] <= 0)
                {
                    continue;
                }

                if (rightTopIndex == -1)
                {
                    rightTopIndex = i;
                }
                else
                {
                    if (charArray[i] > charArray[rightTopIndex])
                    {
                        rightTopIndex = i;
                    }
                }
            }

            if (rightTopIndex == -1)
            {
                return num;
            }

            while (rightTopIndex < charArray.Length - 1 && charArray[rightTopIndex] == charArray[rightTopIndex + 1])
            {
                rightTopIndex++;
            }

            for (var i = 0; i < rightTopIndex; i++)
            {
                if (charArray[i] >= charArray[rightTopIndex])
                {
                    continue;
                }

                (charArray[i], charArray[rightTopIndex]) = (charArray[rightTopIndex], charArray[i]);
                break;
            }

            return Convert.ToInt32(new string(charArray));
        }

        public int MaximumSwap_Version2(int num)
        {
            var charArray = num.ToString().ToArray();
            var rightIndex = -1;
            var leftIndex = -1;
            var maxIndex = -1;

            for (var i = charArray.Length - 1; i >= 0; i--)
            {
                if (maxIndex == -1 || charArray[i] > charArray[maxIndex])
                {
                    maxIndex = i;
                    continue;
                }

                if (charArray[i] >= charArray[maxIndex])
                {
                    continue;
                }

                leftIndex = i;
                rightIndex = maxIndex;
            }

            if (leftIndex == -1)
            {
                return num;
            }

            (charArray[leftIndex], charArray[rightIndex]) = (charArray[rightIndex], charArray[leftIndex]);


            return Convert.ToInt32(new string(charArray));
        }
    }

    // Version1 我想的解法

    // 從右往左找最高點
    // 如果一個高點都沒找到, 代表數字已從大排到小, 沒有交換的必要
    // 如果有最高點, 如果與最高點相鄰的右邊有同樣的數字, 將最高點重覆右移(被 1993 這案例搞到),
    // 再從左邊開始找比最高點小的數字並作交換

    // =====

    // Version2 官方解法更有效率... 一個迴圈就解了
    // 在迴圈內, 由右往右尋找
    //   如果遇到比當前最大值的更大值出現, 更新最大值的 index
    //   否前若當前位置的數字比最大值更小, 更新左右的 index
    // 最後做左右 index 的值做 swap

    // Time: O(N)
    // Space: O(1)
}