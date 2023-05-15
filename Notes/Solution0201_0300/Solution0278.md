# Solution0278

## Binary Search

這題是 easy，但我想了好久..
一開始想說直接寫 code，結果寫起來卡卡的，才發現我應該先做推導

不再是 [Solution0704](../Solution0501_9999/Solution0704.md) 裡的基本題型，我們不能一找到 true 就離開，最好先推導所有情況

可以把 n = 5 的情況都列出來:  
情況一：  
1 2 3 4 5  
F F F F T  

middle = (1 + 5) / 2 = 3 => F  
移動 left = middle + 1 = 4，right 維持 5  

middle = (4 + 5) / 2 = 4 => F  
移動 left = middle + 1 = 5，right 維持 5  

middle = (5 + 5) / 2 = 5 => T  
移動 right = middle - 1 = 4，left 維持 5  

不滿足 left <= right，達到終止條件  
且 left 指向第一個為 T 的版本

情況二：  
1 2 3 4 5  
F F F T T  

middle = (1 + 5) / 2 = 3 => F  
移動 left = middle + 1 = 4，right 維持 5  

middle = (4 + 5) / 2 = 4 => T  
移動 right = middle - 1 = 3，left 維持 4  

不滿足 left <= right，達到終止條件  
且 left 指向第一個為 T 的版本

情況三：  
1 2 3 4 5  
F F T T T  

middle = (1 + 5) / 2 = 3 => T  
移動 right = middle - 1 = 2，left 維持 1  

middle = (1 + 2) / 2 = 1 => F  
移動 left = middle + 1 = 2，right 維持 2  

middle = (2 + 2) / 2 = 2 => F  
移動 left = middle + 1 = 3，right 維持 2  

不滿足 left <= right，達到終止條件  
且 left 指向第一個為 T 的版本

情況四：  
1 2 3 4 5  
F T T T T  

middle = (1 + 5) / 2 = 3 => T  
移動 right = middle - 1 = 2，left 維持 1  

middle = (1 + 2) / 2 = 1 => F  
移動 left = middle + 1 = 2，right 維持 2  

middle = (2 + 2) / 2 = 2 => T  
移動 right = middle - 1 = 1，right 維持 2  

不滿足 left <= right，達到終止條件  
且 left 指向第一個為 T 的版本

情況五：  
1 2 3 4 5  
T T T T T  

middle = (1 + 5) / 2 = 3 => T  
移動 right = middle - 1 = 2，left 維持 1  

middle = (1 + 2) / 2 = 1 => T  
移動 right = middle - 1 = 0，left 維持 1  

不滿足 left <= right，達到終止條件  
且 left 指向第一個為 T 的版本

我們可以歸納出當離開迴圈時，left 會指向第一個 IsBadVersion為 true 的版本  

最後沒注意到 n 的範圍是 1~2<sup>32</sup>-1  
如果上下界很大，那麼 (left + right) / 2 可能會超過 int 32 的最大值  
可以用 left + (right - left) / 2 去解，兩者算出來的結果一樣

### 複雜度

#### Time: O(log(n))

#### Space: O(1)