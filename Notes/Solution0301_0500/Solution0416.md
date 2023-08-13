# Solution0416 Partition Equal Subset Sum

[動態規劃-01背包](https://github.com/thunderstormwang/CodingNotes/blob/main/Algorithms/dynamic_programing_knapsack_problem.md) 的變型題

從 n 個數任意挑選，每個數字物品只能選或不選一次，放入容量 sum/2 的容器，求能放入該容器的最大結果 v  
如果最後 v 跟 sum/2 相等，則表示可以分成兩個相等的子集合

## 動態規劃 - Ver1 - 01 背包 - 2維陣列

### 找出 dp 和下標的的意義
令 dp(n, sum/2) 為 從 num<sub>0</sub>, ..., num<sub>n-1</sub> 共 n 個數任意挑選，每個數字只能選或不選，求放入容量 sum/2 的最大結果

換算成陣列，dp[i][j] 的定義是從 i-1 個數任意挑選，每個數字只能選或被選一次，能放入容量 j 的最大結果。0 <= i < n, 0 <= j <= sum/2

column 的長度有 sum/2 + 1，也就是我們要算出 dp[n-1][sum/2]

### 找出 dp 的狀態推導
dp[i][j] 有兩種可能
- 不選 num<sub>i</sub> 或者說無法放入 num<sub>i</sub>，dp[i-1][j]
- 選 num<sub>i</sub> ，意即從 i-1 個數挑選，求能放入容量 j - 數字<sub>i</sub> 的容器的最大結果 加上 數字<sub>i</sub>，dp[i-1][j - num<sub>i</sub>] + num<sub>i</sub>

從以上兩者取最大

### 找出 dp 初始值
- dp[i][0] = 0，0 <= i <= n，容量是 0 怎麼放結果都是 0
- dp[0][j] = 0，0 <= j <= sum/2，不選擇任何數字，怎麼放結果都是 0

為了計算方便，row 的長度是 n + 1，也就是我們要算出 dp[n][sum/2]

### 複雜度
- 一共有個 n 個數
- 每個數至少為 1，所以 sum 至少為 (n<sup>2</sup> + n) / 2

#### Time: O(n<sup>3</sup>)
- n * sum: O((n<sup>3</sup> + n<sup>2</sup>) / 2)

相加後取最大項: O(n<sup>3</sup>)

#### Space: O(n<sup>2</sup>)

---

## 動態規劃 - Ver1 - 01 背包 - 1維陣列

從二維陣列改一維陣列需要顧慮的點有，前一個要被計算的數值不能被蓋掉

在狀態推導中，dp[i][j] 有二：
- dp[i-1][j]，也就是從上方傳下來，也可以說就是本身的前一個數值
- dp[i-1][j - num<sub>i</sub>] + num<sub>i</sub>，不確定 j - num<sub>i</sub> 是多少，但肯定比 j 小

所以如果將 j 從由大到小走迴圈，就不用擔心前一個數值被蓋掉了

那麼就可以選用一維陣列，dp[j] = Max(d[j], dp[j - num<sub>i</sub>] + num<sub>i</sub>)

### 複雜度

#### Time: O(n<sup>3</sup>)

#### Space: O(n<sup>2</sup>)
