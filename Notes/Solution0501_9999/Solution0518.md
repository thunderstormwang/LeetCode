# Solution0518

## 動態規劃 - Ver1 完全背包 2維陣列

### 找出 dp 和下標的的意義

完全背包問題，從 n 個物品中任意挑選，每個物品有無限多個，放入容量 w 的背包，求能放入背包的最大價值 v

這題轉化為完全背包

從 硬幣<sub>0</sub>, ..., 硬幣<sub>n-1</sub> 共 n 個硬幣任意挑選，每個硬幣有無限多個，求組成 amout 的組合數目 = dp(n, amount)

換算成陣列，是求 dp[n-1][amount]

### 找出 dp 的狀態推導

dp[i][j] 的來源有 2
- 不使用硬幣<sub>i</sub>，dp[i-1][j]
- 使用硬幣<sub>i</sub>，dp[i][j - 硬幣<sub>i</sub>]，j - 硬幣<sub>i</sub> >= 0

兩者相加

### 找出 dp 初始值

為了初始化方便，dp[0][j] = 0，1 <= j <= amount，所以 row 的數目變成 n+1

dp[i][0] = 1，0 <= i <= n-1，組合成零的數目一定是 1

### 複雜度

#### Time: O( coin數目 * amount )

#### Space: O( coin數目 * amount )

---

## 動態規劃 - Ver1 完全背包 1維陣列

dp[i][j] 的來源有 2
- dp[i-1][j]，也就是上一個
- dp[i][j - 硬幣<sub>i</sub>]，j - 硬幣<sub>i</sub> >= 0
  
所以如果將 index 由小計算到大，就能使用到最近的結果

那麼就可以選用一維陣列，dp[j] += dp[j - 硬幣<sub>i</sub>]

換成一維後，for 迴圈的順序會有差別

物品迴圈在外層，背包迴圈在內會求得組合數

背包迴圈在外層，物品迴圈在內層會求得排列數

此題要將物品迴圈在外層

跟 [Solution0377](Solution0377.md)、就差在迴圈的順序

### 複雜度

#### Time: O( coin數目 * amount )

#### Space: O(amount)