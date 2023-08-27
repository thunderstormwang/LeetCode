# Solution0981 Time Based Key-Value Store

## Binary Search

用 Dictionary，Key 為 key，Value 為 List<(int Timestamp, string value)>

然後模擬數個情況，假設現在有個 list 長這樣
|           |   |   |
|-----------|---|---|
| index     | 0 | 1 |
| timestamp | 2 | 5 |

情況一：找 target 為 5  
因為 list 最後一個 timestamp <= 5  
直接回傳 1

情況二： 找 target 為 4  
middle = (0 + 1) / 2 = 0
list[middle] = 2 != 4  
list[middle] = 2 < 4  
移動 left = middle + 1 = 1，right 維持 1

middle = (1 + 1) / 2 = 1
list[middle] = 5 != 4  
list[middle] = 5 > 4  
移動 right = middle - 1 = 0，left 維持 1  

不滿足 left <= right，達到終止條件  
且 left 指向第一個大於等於 target 的 index  
回傳 left - 1

情況三：找 target 為 2  
middle = (0 + 1) / 2 = 0
list[middle] = 2 == 2  
回傳 middle

移動 left = middle + 1 = 1，right 維持 1

情況四：找 target 為 1  
middle = (0 + 1) / 2 = 0
list[middle] = 2 != 1  
list[middle] = 2 > 1  
移動 right = middle - 1 = 0，left 維持 0  

middle = (0 + 0) / 2 = 0  
list[middle] = 2 != 1  
list[middle] = 2 > 1  
移動 right = middle - 1 = -1，left 維持 0  

不滿足 left <= right，達到終止條件  
但 left 指向 0，但 list[0] 又大於 target
此案例沒有符合的答案

我們可以歸納出當離開迴圈時，left 會指向第一個大於等於 target 的 timestamp 的 index，但如果為 0 代表所有在 list 的 timestamp 都比 target 大，只能回傳空字串  

### 複雜度

#### Time: O(n * log(n))
- 假設有 list 有 n 個元素，且有 n 個 get 指令

#### Space: O(n)
- 可能有 n 個 set 指令