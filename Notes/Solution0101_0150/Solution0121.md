# Solution0121 Best Time to Buy and Sell Stock

## 暴力法

每個陣列元素皆計算最大獲利  
第 1 個元素要計算 n-1  
第 2 個元素要計算 n-2  
...  
第 n-1 個元素要計算 1  

### 複雜度

#### Time: O(n<sup>2</sup>)  

#### Memory: O(1)  

---

## 貪心解法

令 minPrice 初始為 prices[0], maxProfit 初始為 0  
然後遍歷陣列  
- 更新成本: `minPrice = Math.Min(minPrice, prices[i])`
- 更新利潤: `maxProfit = Math.Max(maxProfit, prices[i] - minPrice)`

### 複雜度

#### Time: O(n)

#### Memory: O(n)

---

## 動態規劃

### 找出 dp 和下標的的意義

dp(n, 0) 為第 n 天持有股票的最低成本，換算成陣列，求 dp[n-1][0]  
dp(n, 1) 為第 n 天無持有股票的最高獲利，換算成陣列，求 dp[n-1][1]  

因為題目要求最後不能持有股票，所以 dp[n-1][1] 就是答案

### 找出 dp 的狀態推導

dp[i][0] (持有投票)的來源有以下
- 第 i - 1 天已持有股票的最低成本，dp[i-1][0]
- 第 i 天買入股票的成本，-1 * prices[i]

兩者取最大

dp[i][1] (無持有投票)的來源有以下
- 第 i - 1 天已賣出股票的最高獲利，dp[i-1][1]
- 第 i 天賣出股票的獲利，dp[i-1][0] + prices[i] 

兩者取最大

### 找出 dp 初始值

dp[0][0] = prices[0]，第 0 天就持有股票，成本為 -1 * prices[0]  
dp[0][1] = 0，第 0 天就不持有股票，此時也沒有股票可賣，獲利為 0

### 複雜度

#### Time: O(n)

#### Memory: O(n)