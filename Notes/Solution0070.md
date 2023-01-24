# Solution0070

其實就是計算費式數列

- 找出 dp 的意義：爬到 n 階的方式 = dp[n]

- 找出 dp 的狀態推導：dp[i] = dp[i-2] + dp[i-1]。在 dp[i-1] 只能選擇爬 1 階上到 index<sub>i</sub>。在 dp[i-2] 也只能選擇爬 2 階上到 index<sub>i</sub>，因為若是先爬 1 階上到 index<sub>n-1</sub>，再爬 1 階上到 index<sub>i</sub>，就會跟 dp[i-1] 重覆計算。

- 找出 dp 初始值：dp[1] = 1, dp[2] = 2。

Time: O(N)

Space: O(1)