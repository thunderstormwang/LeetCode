# Solution0063

## 動態規劃

### 定義 dp
到 m, n 的所有不同路徑 = dp(m,n)  

### 定義 dp 的狀態推導
每個格子可以從其上方或左方來，也須考慮格子本身有沒有障礙
- 如果 obstacleGrid[i][j] == 1，dp[i][j] = 0
- 其它情況，dp[i][j] = dp[i-1][j] + dp[i][j-1]
  
### 定義 dp 初始值
dp[i][0]，0 <= i < m，有以下情況
- 當 obstacleGrid[i][0] == 1，dp[i][0] 是 0
- 否則等於 dp[i-1][0]

dp[0][j]，0 <= j < n，有以下情況
- 當 obstacleGrid[0][j] == 1，dp[0][j]是 0
- 否則等於 dp[0][j-1]

看了解答，發現初始值有個更好的想法：當遇到障礙後，後面都是 0

### 複雜度

#### Time: O(M * N)

#### Space: O(M * N)