# Solution0055

我的想法: 用 index 記錄現在位置, 用 max 記錄能跳的最遠距離，只要 index + nums[index] >= nums.Length 就代表能到達最後一個位置，
若沒有就繼續找。

- index + num[index] > max，就讓 max = index + num[index]，再從 max 開始找起
- index + num[index] <= max，就 index -1 再往前一個位置找起

```csharp
public bool CanJump(int[] nums)
{
    var index = nums[0];
    var max = nums[0];

    while (index >= 0)
    {
        if (index >= nums.Length-1)
        {
            return true;
        }

        var temp = index + nums[index];
        if (temp > max)
        {
            max = temp;
            index = temp;
        }
        else
        {
            index--;
        }
    }

    return false;
}
```

<br/>這可以算出解答，但沒有以下解法漂亮:

能否到第 n 個位置??
<br/>最遠距離(nums[0] ~ nums[n-1]) 能否到 n ??
<br/>...
<br/>能否到第 i 個位置??
<br/>最遠距離(nums[0] ~ nums[i-1]) 能否到 i ??
<br/>...
<br/>能否到第 2 個位置??
<br/>最遠距離(nums[0] ~ nums[1]) 能否到 2 ??
<br/>...
<br/>能否到第 1 個位置??
<br/>最遠距離(nums[0] ~ nums[0]) 能否到 1 ??

反過來看...

能否到第 1 個位置??
<br/>最遠距離(nums[0] ~ nums[0]) 能否到 1 ??
<br/>(0+ nums[0]) >= 1 ??
<br/>...
<br/>能否到第 2 個位置??
<br/>最遠距離(nums[0] ~ nums[1]) 能否到 2 ??
<br/>MAX(0+nums[0], 1+nums[1]) >= 1 ??
<br/>...
<br/>能否到第 i 個位置??
<br/>最遠距離(nums[0] ~ nums[i-1]) 能否到 i ??
<br/>MAX(0+nums[0], 1+nums[1], ... , i-1+nums[i-1]) >= i ??
<br/>...
<br/>能否到第 n 個位置??
<br/>最遠距離(nums[0] ~ nums[n-1]) 能否到 n ??
<br/>MAX(0+nums[0], 1+nums[1], ... , n-1+nums[n-1]) >= n ??

所以只要從 0 開始跑完陣列，也不需要倒退
一直更新 max = MAX(max, 0+nums[0], 1+nums[1], ... , i+nums[i])

如果現在位置 > max，就代表到不了最後一個位置，可提早結束

只要迴圈結束後 max 有大於等於陣列長度-1，就代表能到最後一個位置

Time: O(N)

Space: O(1)