# Solution0053

#### 動態規劃

令 dp(n) 為到 index n 的最少 jump:

dp(n) = min(dp(n-1), ... dp(1), dp(0)) + 1
<br/>...
<br/>dp(i) = min(dp(i-1), ... dp(1), dp(0)) + 1
<br/>...
<br/>dp(1) = min( dp(0)) + 1
<br/>dp(0) = 1

以這題來說不是最佳解

Time: O(N^2)

dp(0) 計算 1 次, dp(1) 計算 2 次, ... ,dp(n) 計算 n-1 次，n*(1+n) / 2，所以是 N^2

Time: O(N)

#### 貪心解法

第 1 次跳至少能到達的位置: start<sub>1</sub> = 0
<br/>第 1 次跳能到達的位置: end<sub>1</sub> = num[0]

第 2 次跳至少能到達的位置: start<sub>2</sub> = end<sub>1</sub> + 1
<br/>第 2 次跳能到達的位置: end<sub>2</sub> = Max(start<sub>1</sub> + num[start<sub>1</sub>], ... , end<sub>1</sub> + num[end<sub>1</sub>])

...

第 i 次跳至少能到達的位置: start<sub>i</sub> = end<sub>1-1</sub> + 1
<br/>第 2 次跳能到達的位置: end<sub>i</sub> = Max(start<sub>i-1</sub> + num[start<sub>i-1</sub>], ... , end<sub>i-1</sub> + num[end<sub>i-1</sub>])

Time: O(N)

Time: O(1)