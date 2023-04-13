# Solution0583

## 動態規劃 Ver1, Ver2 - 計算公共子序列長度

跟 [Solution1143](Solution1143.md) 類似  
把dp[n][m] 算出來後，要多做一步，word1 長度 加上 word2 長度 扣掉 2 *dp[n][m] 才是答案

---

## 動態規劃 Ver3, Ver4 - 直接計算最小刪除數目

[Solution0392](Solution0392.md) 的進階版  

### 找出 dp 和下標的的意義

在長度為 n 的 word1 與長度為 m 的 wrod2 所需要刪除的元素的最小數目 = dp(n,m)，換算成陣列求 dp[n-1][m-1]

### 找出 dp 的狀態推導

dp[i][j] 的來源有以下
- text1[i] = text[j]，那就等於長度為 i-1 的 word1 和 長度為 j-1 的 word2 的最小數目，也就是 dp[i-1][j-1]
- 反之，就從以下取最小
  - 從長度為 i-1 的 word1 和 長度為 j 的 wrod2 的最小數目加 1，也就是 dp[i-1][j] + 1
  - 從長度為 i 的 word1 和 長度為 j-1 的 word2 的最小數目加 1，也就是 dp[i][j-1] + 1

### 找出 dp 初始值

因為計算來源有 dp[i-1][j-1]，須把 dp[0][j] 另外計算，發現要想一些判斷，dp[i][0] 也是一樣的情況

讓陣列的數目各加 1，可免去這些麻煩，換成求 dp[n][m]

dp[i][0] = i，0 <= i <= n  
dp[0][j] = j，0 <= j <= m

#### Time: O(n*m)

#### Space: O(n*m)