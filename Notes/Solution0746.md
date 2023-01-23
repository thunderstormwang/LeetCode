# Solution0509

#### 動態規劃

- 找出 dp 的意義：陣列 index<sub>0</sub>, index<sub>1</sub>, ... , index<sub>n-1</sub>, 爬到 index<sub>n</sub> 的最小花費 = dp[n]
- 找出 dp 的狀態推導：dp[i] = Math.Min(dp[i-2] + cost[i-2], dp[i-1] + cost[i-1])
- 找出 dp 初始值：dp[0] = 0, dp[1] = 0

Time: O(N)

Space: O(N)