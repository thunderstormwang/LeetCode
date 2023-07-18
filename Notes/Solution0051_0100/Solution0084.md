# Solution0084

我喜歡這題, 很容易就想到暴力法怎麼解, 然後再去想該怎麼優化

## 暴力法

在每個 height[i] 往左找第一個比它小的高度，也往右找找第一個比它小的高度  
如此就找到 height[i] 的最大寬度，也就能算出矩形面積  

### 複雜度

#### Time: O(n<sup>2</sup>)
- 每個 index i，往左和往右，會用掉 n 次運算，所以總共 n<sup>2</sup> 次運算: O(n<sup>2</sup>)


#### Space: O(1)

---

## Monotonic Stack 單調棧

解法同 [Solution0042](../Solution0001_0050/Solution0042.md)，不過是遞增形式的單調棧

使用 Stack，儲存 index，越往頂端，heights[i] 則越高，形成遞增形式的單調棧

遍歷 heights，假設當前 index 為 i，且假定 Stack 的頂端元素是 curr，curr = Stack.Peek()
- 如果 heights[i] >= heights[curr]
  - Stack.Push(i)  
- 如果 heights[i] < heights[curr]，代表 curr 已各在左右找到第一個比它小的高度
  - curr = Stack.Pop()
  - right = i - 1
  - 因為是單調棧，此時 hegits[Stack.Peek()] 也會小於等於 heights[curr]，left = Stack.Count == 0 ? 0 : Stack.Peek() + 1
  - 當前面積 = heights[curr] * (right - left + 1)
  - 更新 curr
  - 重覆上述過程直到 heights[i] >= heights[curr] 或是 stack 沒有元素為止
  - stack.Push(i)  

遍歷完 heights，仍需將 stack 清空，流程與上述相同

### 複雜度

#### Time: O(n)
- 寫出來會發現很多層迴圈，不過 heights 每個元素只會被放入 stack 一次，且取出時才會計算以它為基準的最大面積，所以是 n 次運算: O(n)

#### Space: O(n)
- stack 最多存 n 個元素: O(n)
