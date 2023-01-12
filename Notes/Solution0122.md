﻿# Solution0122

一開始我想說用變數記下上次買點、上次賣點、現在手中有無股票

上次買點: price[i] > price[i-1] 且手中無股票

上次賣點: price[i] < price[i-1] 且手中有股票，並累計到 profit 上

不過這是想得太複雜了...

#### 貪心解法：

依照貪心算法的定義，找到局部最優解並推出最優解

因為股票可以當天買又當天賣，那局部最優解就是只要當天股票價比昨天高，就做一買一賣；當天股票價比昨天低，就不做買賣。

例如計算第 0 天到第 3 天的利潤 price[3] - price[0] 也就是
(price[3] - price[2]) + (price[2] - price[1]) + (price[1] - price[0])，
如果 (price[2] - price[1]) 算出來為負，那天就不做買賣

所以把每天的正利潤相加即可

Time: O(N)

Memory: O(1)

#### 動態規劃：