# Solution0509

#### 動態規劃 Iterative Ver1

- 找出 dp 的意義：Fib(n) = dp[n]
- 找出 dp 的狀態推導：dp[i] = dp[i-2] + dp[i-1]
- 找出 dp 初始值：dp[0] = 0, dp[1] = 1

Time: O(N)

Space: O(N)

#### 動態規劃 Iterative Ver2

只要第 N 個結果的話，可以不用陣列記錄每個結果

Time: O(N)

Space: O(1)

#### 動態規劃 Recursive Ver1

Time: O(2^N) -- 展開有點像是 2^(N-1) 的 complete tree，算作 2^N

Space: O(N) -- 最多遞迴到 N-1 層，算作 N

#### 動態規劃 Recursive Ver2

用陣列記錄已算過的數值

Time: O(N) -- 1 ~ N 之間的每個數值都須計算過一次

Space: O(N)