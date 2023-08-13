# Solution0322 Coin Change

[動態規劃-完全背包](https://github.com/thunderstormwang/CodingNotes/blob/main/Algorithms/dynamic_programing_knapsack_problem.md) 的變型題

## Ver1 - 動態規劃 - 完全背包 2維陣列

### 找出 dp 和下標的的意義

從 硬幣<sub>0</sub>, ..., 硬幣<sub>n-1</sub> 共 n 個硬幣任意挑選，每個硬幣有無限多個，求組成 amout 的最小組合數目 = dp(n, amount)

換算成陣列，有 n-1 條 row、amount+1 條 column，所以找 dp[n-1][amount]

### 找出 dp 的狀態推導

在推導過程中畫出二維陣列會較好理解

dp[i][j] 的來源有 2:
- 不使用或是無法使用 硬幣<sub>i</sub>，dp[i - 1][j]
- 使用 硬幣<sub>i</sub>，dp[i][j - 硬幣<sub>i</sub>] + 1，硬幣<sub>i</sub> <= j <= amount

兩者取最小

### 找出 dp 初始值

dp[i][0] = 0，0 <= i <= n，用任何硬幣組成零的組合數目一定是 0  

dp[0][j] = -1，0 <= j <= amount  
為了初始化方便，增加第 0 列代表不使用任何硬幣，如此就應該要求出 dp[n][amount]

初始化為 -1 是為了避免 int.MaxValue + 1 造成溢位的問題，  
因為用了 -1 代表無法達成的數目，在求 dp 的狀態推導時就要小心地處理 -1。

### 複雜度
- coins 的長度: n
- amount: m

#### Time: O(n*m)

#### Space: O(n*m)

---

## Ver2 - 動態規劃 - 完全背包 1維陣列

觀察 Ver1，可以發現
dp[i][j] 的來源有 2:
- dp[i-1][j]，也就是從上層帶下來
- dp[i][j-硬幣<sub>i</sub>] + 1，j-硬幣<sub>i</sub> 肯定比 j 小

所以如果將 index 都由小計算到大，都不用怕要被計算的值會先被蓋掉  
那麼就可以選用一維陣列，dp[j] = Min(dp[j], dp[j - 硬幣<sub>i</sub>] + 1)  

### 複雜度
- coins 的長度: n
- amount: m

#### Time: O(n*m)

#### Space: O(n*m)