# Solution0042 Trapping Rain Water

我喜歡這題, 很容易就想到暴力法怎麼解, 然後再去想該怎麼優化

## 暴力法

遍歷陣列 height  
在每個 height<sub>i</sub> 分別往左往右找最高點  
再計算該點能容納多少雨量

### 複雜度

#### Time: O(n<sup>2</sup>)
- 每個 index i，往左和往右，會用掉 n 次運算，所以總共 n<sup>2</sup> 次運算: O(n<sup>2</sup>)

#### Space: O(1)

---

## 優化暴力法

可以觀察到每個 height<sub>i</sub> 都要做一次分別往左往右找最高點  
是重覆的行為

可以先由左往右跑一次迴圈，記錄每個 height<sub>i</sub> 往左的最高點  
leftHeight[i] = Math.Max(leftHeight[i-1], height[i])

也由右往左跑一次迴圈，記錄每個 height<sub>i</sub> 往右的最高點   
rightHeight[i] = Math.Max(rightHeight[i+1], height[i])

再計算 height<sub>i</sub> 能容納多少雨量

### 複雜度

#### Time: O(n)
- 遍歷 height，計算 leftHeight: O(n)
- 遍歷 height，計算 rightHeight: O(n)
- 遍歷 height，計算 height<sub>i</sub> 能容納多少雨量: O(n)

#### Space: O(n)
- leftHeight 大小: O(n)
- rightHeight 大小: O(n)

---

## Stack Ver1

看了提示說用 Stack，我自己想出的方法，事後才知道這叫單調棧(Monotonic Stack)，但我想的方法又跟單調棧的解法不一樣

在由左往右的過程中，height<sub>i</sub> 往左的最高點很好找  
難的是往右的最高點，就使用 Stack 來記錄  

Stack 存放 index，且越接近頂端的元素，高度就越高  
Stack 的初始化方式為為由右往左，當 height<sub>i</sub> 比左右兩邊都高，也比 Stack 的頂端高時，就放入 Stack  

接著就可以由左往右計算每個 height<sub>i</sub> 能容納多少雨量  
在每個 i 也要重新計算左邊最高點，如果 i 等於 Stack 的頂端元素，就把 Stack pop，重取一個右邊最高點

### 複雜度

#### Time: O(n)

#### Space: O(n)

---

## Ver2 - Monotonic Stack - 單調棧

解法同 [Solution0084](../Solution0051_0100/Solution0084.md)，不過是遞減形式的單調棧

使用 Stack，儲存 index，越往頂端，height<sub>index</sub> 則越低，形成遞增形式的單調棧  

遍歷 height，假設當前 index 為 i，且假定 Stack 的頂端元素是 curr
- 如果 height<sub>i</sub> <= height[curr]
  - Stack.Push(i)  
- 如果 height<sub>i</sub> > heights[curr]，代表 curr 已各在左右找到第一個比它高的高度
  -

抄自原 42

比較 height<sub>i</sub> 和 Stack 的頂端元素對應到的高度
- height<sub>i</sub> <= Stack 的頂端元素對應到的高度
  - Stack.Push(i)  
- height<sub>i</sub> > Stack 的頂端元素對應到的高度，
  - 代表 Stack 的頂端元素找到右邊第一個比它高的高度，而左邊第一個比它高的高度就是 它的下一個元素，那就可以能容納的雨水容量了
  - 能容納的雨水容量的寬度 = 右邊 - 左邊 - 1
  - 能容納的雨水容量的高度 = Math.Min(右邊高度, 左邊高度) - height<sub>i</sub>
  - 此過程持續到 height<sub>i</sub> <>= Stack 的頂端元素對應到的高度 或是 Stack 只剩一個元素為止

抄自 84

遍歷 heights，假設當前 index 為 i，且假定 Stack 的頂端元素是 curr
- 如果 height<sub>i</sub> >= heights[curr]
  - Stack.Push(i)  
- 如果 height<sub>i</sub> < heights[curr]，代表 curr 已各在左右找到第一個比它小的高度
  - left = Stack.Pop()
  - right = i - 1
  - 因為是單調棧，此時 Stack 的頂端元素所對應的高度也會小於等於 height[curr]，left = Stack.Count == 0 ? 0 : Stack.Peek() + 1
  - 當前面積 = height[curr] * (right - left + 1)
  - 更新 curr
  - 重覆上述過程直到 height<sub>i</sub> >= heights[curr] 為止

遍歷完 heights，仍需將 stack 清空，流程與上述相同

### 複雜度

#### Time: O(n)

#### Space: O(n)
- Stack 最多儲的元素: O(n)