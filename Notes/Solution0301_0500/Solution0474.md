# Solution0474

## 動態規劃 - 01背包 3維陣列

### 找出 dp 和下標的的意義

從 str<sub>0</sub>, ..., str<sub>p-1</sub> 共 p 個字串任意挑選，每個字串只能選或不選，求最多 m 個 0, n 個 1 的最大子集合包含的元素數量 = dp(p, m. n)

換算成陣列，要求出 dp[p-1][m][n]

### 找出 dp 的狀態推導

dp[k][i][j] 來源有以下
- 不選 str<sub>k</sub>，dp[k-1][i][j]
- 選 str<sub>k</sub>，dp[k-1][i - zero<sub>k</sub>][j - one<sub>k</sub>]，zero<sub>k</sub> <= i <= m，one<sub>k</sub> <= j <= n

以上取最大

### 找出 dp 初始值

dp[0][i][j] = 1，zero<sub>0</sub> <= i <= m，one<sub>0</sub> <= j <= n

若是覺得這樣初始化麻煩，可以改定義，dp[0][i][j] 為沒有字串可選，那麼就可都初始化為 0，變成求 dp[p][m][n]

### 複雜度

#### Time: O(k * m * n)

#### Space: O(k * m * n)

---

## 動態規劃 - 01背包 2維陣列

從三維陣列改二維陣列需要顧慮的點有，前一個要被計算的數值不能被蓋掉

在狀態推導中，dp[k][i][j] 有二：
- dp[k-1][i][j]，也就是同樣的 i, j
- dp[k-1][i - zero<sub>k</sub>][j - one<sub>k</sub>]，不確定 i - zero<sub>k</sub> 是多少，但肯定小於等於 i，j 也是同理

所以如果將 i, j 從由大到小走迴圈，就不用擔心前一個數值被蓋掉了

那麼就可以選用二維陣列，dp[i][j] = Math.Max(d[i][j], dp[i - zero<sub>k</sub>][j - one<sub>k</sub>])

#### Time: O(k * m * n)

#### Space: O(m * n)