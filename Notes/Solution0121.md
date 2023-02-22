# Solution0121

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

令 minPrice 為 prices[1]

走一遍陣列，計算 price[i] 減去 minPrice 並更新最大利潤，然後更新 minPrice = Math.Min(minPrice, prices[i])

### 複雜度

#### Time: O(n)

#### Memory: O(n)

---

## 動態規劃

### 找出 dp 和下標的的意義

dp_buy(n) 為 1~n 天中買股票的最低成本，換算成陣列，求 dp_buy[n-1]

dp_sell(n) 為 1~n 天中賣股票的最高獲利，換算成陣列，求 dp_sell[n-1]

### 找出 dp 的狀態推導

dp_buy[i]的來源有以下
- 0 ~ i-1 天買入股票的最低成本，dp_buy[i-1]
- 第 i 天買入股票的成本，prices[i]

兩者取最小

dp_sell[i]的來源有以下
- 0 ~ i-1 天賣出股票的最高獲利，dp_sell[i-1]
- 第 i 天賣出股票的獲利，prices[i] - dp_buy[i-1]

兩者取最大

### 找出 dp 初始值

dp_buy[0] = prices[0]，第 0 天就買股票，成本為 prices[0]

dp_sell[0] = 0，股票不能同一天買賣，第 0 天的獲利為 0

### 複雜度

#### Time: O(n)

#### Memory: O(n)