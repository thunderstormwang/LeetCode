# Solution0714

#### 暴力法

每個陣列元素皆計算最大獲利

第 1 個元素要計算 n-1 

第 2 個元素要計算 n-2

...

第 n-1 個元素要計算 1

Time: O(N^2)

Memory: O(1)

#### 貪心解法

令 minPrice 為 prices[1]

走一遍陣列，計算 price[i] 減去 minPrice 並更新最大利潤，然後更新 minPrice = Math.Min(minPrice, prices[i])

Time: O(N)

Memory: O(1)

#### 動態規劃

待補