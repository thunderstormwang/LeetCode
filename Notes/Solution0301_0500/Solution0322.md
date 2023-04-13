# Solution0322

## 動態規劃 - 完全背包 2維陣列

完全背包問題的變型題

### 找出 dp 和下標的的意義

從 硬幣<sub>0</sub>, ..., 硬幣<sub>n-1</sub> 共 n 個硬幣任意挑選，每個硬幣有無限多個，求組成 amout 的最小組合數目 = dp(n, amount)

換算成陣列，找 dp[n-1][amount]

### 找出 dp 的狀態推導

在推導過程中畫出二維陣列會較好理解

dp[i][j] 的來源有 2:
- 不使用或是無法使用 硬幣<sub>i</sub>，dp[i-1][j]
- 使用 硬幣<sub>i</sub>，dp[i][j-硬幣<sub>i</sub>] + 1，硬幣<sub>i</sub> <= j <= amount

兩者取最小

### 找出 dp 初始值

dp[i][0] = 0，0 <= i <= n，用任何硬幣組成零的組合數目一定是 0

dp[0][j] = -1，0 <= j <= amount

為了初始化方便，增加第 0 列，如此就應該要求出 dp[n][amount]

初始化為 -1 是為了避免 int.MaxValue + 1 造成溢位的問題

### 複雜度

#### Time: O( coin.length * amount )

#### Space: O( coin.length * amount )

---

## 動態規劃 - 完全背包 1維陣列

dp[i][j] 的來源有 2:
- dp[i-1][j]，也就是從上層帶下來
- dp[i][j-硬幣<sub>i</sub>] + 1，j-硬幣<sub>i</sub> 肯定比 j 小

所以如果將 index 由小計算到大，就能使用到最近的結果

那麼就可以選用一維陣列，dp[j] = Min(dp[j], dp[j - 硬幣<sub>i</sub>] + 1)

### 複雜度

#### Time: O( coin.length * amount )

#### Space: O(amount)