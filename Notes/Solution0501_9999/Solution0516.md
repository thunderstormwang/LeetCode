# Solution0516

## 動態規劃

這題完全沒想法...

### 找出 dp 和下標的的意義

s<sub>0</sub> ~ s<sub>n-1</sub> 的最大回文子序列 = dp(0, n-1)，換算成陣列，求 dp[0][n-1]

### 找出 dp 的狀態推導

dp[i][j] 的來源
- 如果 s<sub>i</sub> = s<sub>j</sub>，dp[i+1][j-1] + 2
- 反之，那就一次加入一個字元，看看 s<sub>i+1</sub>~s<sub>j</sub> 或 s<sub>i</sub>~s<sub>j-1</sub> 哪個回文子序列較大，也就是 Max(dp[i+1][j], dp[i][j-1]) → 這步好想難...

### 找出 dp 初始值

dp[i][i] = 1，0 <= i <= n-1

#### Time: O(n<sup>2</sup>)

#### Space: O(n<sup>2</sup>)