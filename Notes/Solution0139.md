# Solution0139

## 動態規劃 - 完全背包 1維陣列

想法同 322

一維寫得出來，二維不知道怎麼寫

### 找出 dp 和下標的的意義

長度 n 的字串是否能匹配成功 = dp(n)

換算成陣列，找 dp[n-1]

### 找出 dp 的狀態推導

在 d[j] 這位置，只要能找到一個 word<sub>i</sub>，使得 d[j - word<sub>i</sub>長度] 為 true，那麼 d[j] 就為 true，反之為 false

### 找出 dp 初始值

為了初始化方便，令 d[0] 為 true，所以 column 的數多多 1，那麼就改成求 dp[n]

### 複雜度

#### Time: O( 字串長度 * wordDict 長度)

#### Space: O(字串長度)