# Solution0528 Random Pick with Weight

雖然知道是 Binary Search，但我還是錯很多久...

## Math

由於 i 出現的機率跟 w[i] 有關，  
建立陣列 _cumulativeSum，令 _cumulativeSum[i] = w[0] + w[1] + ... + w[i]。  
當我們要隨機選取一個數字時，從 1 到 _cumulativeSum[n-1] 中隨機選取一個數字，再從_cumulativeSum 中找到第一個大於等於該數字的索引，即為答案。

尋找過程可用 Binary Search，  
當 _cumulativeSum[middle] < target 時，代表答案在 middle 的右邊，令 left = middle + 1。  
當 _cumulativeSum[middle] >= target 時，代表答案在 middle 的左邊，令 right = middle。

重覆上述過程直到 left == right，此時 left 即為答案。 

### 複雜度

#### Time: O() ??
- 建立初始陣列 _cumulativeSum: O(n)
- 每次呼叫 pickIndex: O(log(n))

#### Space: O(n)
- 陣列 w 的長度: O(n)