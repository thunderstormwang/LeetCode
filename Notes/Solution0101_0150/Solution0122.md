﻿# Solution0122

一開始我想說用變數記下上次買點、上次賣點、現在手中有無股票

上次買點: price[i] > price[i-1] 且手中無股票

上次賣點: price[i] < price[i-1] 且手中有股票，並累計到 profit 上

不過這是想得太複雜了...

## 貪心解法：

依照貪心算法的定義，找到局部最優解並推出最優解

因為股票可以當天買又當天賣，那局部最優解就是只要當天股票價比昨天高，就做一買一賣；當天股票價比昨天低，就不做買賣。

例如計算第 0 天到第 3 天的利潤 price[3] - price[0] 也就是
(price[3] - price[2]) + (price[2] - price[1]) + (price[1] - price[0])，
如果 (price[2] - price[1]) 算出來為負，那天就不做買賣

所以把每天的正利潤相加即可

### 複雜度

#### Time: O(n)

#### Memory: O(1)

## 動態規劃

跟 [Solution121](Solution0121.md) 不同的是，獲利得累積到下一天，所以 dp 的定義也不一樣

### 找出 dp 和下標的的意義

第 n 天持有股票的最大獲利: dp_stock(n)，換算成陣列，求 dp_stock[n-1]

第 n 天無持有股票的最大獲利: dp_no_stock(n)，換算成陣列，求 dp_no_stock[n-1]

### 找出 dp 的狀態推導

dp_stock[i] 的來源有以下
- 第 i-1 天持有股票的最大獲利，dp_stock[i-1]
- 第 i-1 天無持有股票的最大獲利 扣掉 第 i 天買股票的成本，dp_no_stock[i-1] - prices[i]

兩者取最大

dp_no_stock[i] 的來源有以下
- 第 i-1 天無持有股票的最大獲利，dp_no_stock[i-1]
- 第 i-1 天持有股票的最大獲利 加上 第 i 天賣股票的獲利，dp_stock[i-1] + prices[i]

兩者取最大

### 找出 dp 初始值

dp_stock[0] = -prices[0]，第一天前面不會再有前一天了，只有買入股票此一情況

dp_no_stock[0] = 0，第一天沒股票可賣

### 複雜度

#### Time: O(n)

#### Memory: O(n)