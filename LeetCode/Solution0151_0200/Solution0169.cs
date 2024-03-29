﻿namespace LeetCode.Solution0151_0200;

public class Solution0169
{
    public int MajorityElement(int[] nums)
    {
        var result = 0;
        var count = 0;

        foreach (var item in nums)
        {
            if (count == 0)
            {
                result = item;
            }

            count += item == result ? 1 : -1;
        }

        return result;
    }
}