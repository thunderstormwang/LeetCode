# Solution0283

## Two Pointer

由左向右輪詢陣列，low 指向第一個遇到的 0  
接著由 fast 從 low + 1 開始輪詢陣列，遇到非 0 的數就跟 low 交換元素  

### 複雜度

#### Time: O(n)

#### Space: O(1)