# Solution0714

## 暴力法

每個陣列元素皆計算最大獲利

第 1 個元素要計算 n-1 

第 2 個元素要計算 n-2

...

第 n-1 個元素要計算 1

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Memory: O(1)

## 貪心解法

令 minPrice 為 prices[1]

走一遍陣列，計算 price[i] 減去 minPrice 並更新最大利潤，然後更新 minPrice = Math.Min(minPrice, prices[i])

#### Time: O(n)

#### Memory: O(n)

## 動態規劃

### 找出 dp 和下標的的意義

dp_buy(n) 為買股票的最低成本，換算成陣列，求 dp_buy[n-1]

dp_sell(n) 為賣股票的最高獲利，求 dp_sell[n-1]

### 找出 dp 的狀態推導

### 找出 dp 初始值

#### Time: O(n)

#### Memory: O(n)