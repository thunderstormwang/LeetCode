namespace LeetCode.Solution0701_9999;

public class Solution1235
{
    public int JobScheduling_Ver1(int[] startTime, int[] endTime, int[] profit)
    {
        var n = startTime.Length;
        var jobs = new int[n][];
        for (var i = 0; i < jobs.Length; i++)
        {
            jobs[i] = new int[] { startTime[i], endTime[i], profit[i] };
        }

        Array.Sort(jobs, (x, y) =>
        {
            if (x[1] < y[1])
            {
                return -1;
            }

            if (x[1] > y[1])
            {
                return 1;
            }

            if (x[0] < y[0])
            {
                return -1;
            }

            return 1;
        });

        var dp = new int [n];
        dp[0] = jobs[0][2];

        for(var i = 1; i < n; i++)
        {
            var prevIndex = BinarySearch(jobs, i-1, jobs[i][0]);
            dp[i] = Math.Max(dp[i-1], jobs[i][2] + (prevIndex == -1 ? 0 : dp[prevIndex]));
        }

        return dp[n-1]; 
    }

    /// <summary>
    /// 會超時
    /// <br/>01背包，縱軸為工作，橫軸為時間
    /// <br/>二維陣列
    /// </summary>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <param name="profit"></param>
    /// <returns></returns>
    public int JobScheduling_Ver2(int[] startTime, int[] endTime, int[] profit)
    {
        var n = startTime.Length;
        var jobs = new int[n][];
        for (var i = 0; i < jobs.Length; i++)
        {
            jobs[i] = new int[] { startTime[i], endTime[i], profit[i] };
        }

        Array.Sort(jobs, (x, y) =>
        {
            if (x[1] < y[1])
            {
                return -1;
            }

            if (x[1] > y[1])
            {
                return 1;
            }

            if (x[0] < y[0])
            {
                return -1;
            }

            return 1;
        });

        var maxEndTime = jobs[n - 1][1];
        var dp = new int [n + 1][];
        for (var i = 0; i <= n; i++)
        {
            dp[i] = new int [maxEndTime + 1];
        }

        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j <= maxEndTime; j++)
            {
                if (j < jobs[i - 1][1])
                {
                    dp[i][j] = dp[i - 1][j];
                }
                else
                {
                    var prevIndex = BinarySearch(jobs, i - 2, jobs[i - 1][0]);
                    dp[i][j] = Math.Max(dp[i - 1][j], jobs[i - 1][2] + (prevIndex == -1 ? 0 : dp[i - 1][jobs[prevIndex][1]]));
                }
            }
        }

        return dp[n][maxEndTime];
    }

    /// <summary> 
    /// 會超時
    /// <br/>01背包，縱軸為工作，橫軸為時間
    /// <br/>一維陣列
    /// </summary>
    /// <param name="startTime"></param>
    /// <param name="endTime"></param>
    /// <param name="profit"></param>
    /// <returns></returns>
    public int JobScheduling_Ver3(int[] startTime, int[] endTime, int[] profit)
    {
        var n = startTime.Length;
        var jobs = new int[n][];
        for (var i = 0; i < jobs.Length; i++)
        {
            jobs[i] = new int[] { startTime[i], endTime[i], profit[i] };
        }

        Array.Sort(jobs, (x, y) =>
        {
            if (x[1] < y[1])
            {
                return -1;
            }

            if (x[1] > y[1])
            {
                return 1;
            }

            if (x[0] < y[0])
            {
                return -1;
            }

            return 1;
        });

        var maxEndTime = jobs[n - 1][1];
        var dp = new int [maxEndTime + 1];

        for (var i = 1; i <= n; i++)
        {
            for (var j = maxEndTime; j >= 1; j--)
            {
                if (j < jobs[i - 1][1])
                {
                    dp[j] = dp[j];
                }
                else
                {
                    var prevIndex = BinarySearch(jobs, i - 2, jobs[i - 1][0]);
                    dp[j] = Math.Max(dp[j], jobs[i - 1][2] + (prevIndex == -1 ? 0 : dp[jobs[prevIndex][1]]));
                }
            }
        }

        return dp[maxEndTime];
    }

    private int BinarySearch(int[][] jobs, int endIndex, int targetEndTime)
    {
        var left = 0;
        var right = endIndex;
        var prevIndex = -1;
        while (left <= right)
        {
            var middle = left + (right - left) / 2;
            if (jobs[middle][1] <= targetEndTime)
            {
                prevIndex = middle;
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return prevIndex;
    }
}