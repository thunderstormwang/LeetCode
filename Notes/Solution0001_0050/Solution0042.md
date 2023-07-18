# Solution0042 Trapping Rain Water

我喜歡這題, 很容易就想到暴力法怎麼解, 然後再去想該怎麼優化

## 暴力法

遍歷陣列 height  
在每個 height[i] 分別往左往右找最高點  
再計算該點能容納多少雨量

### 複雜度

#### Time: O(n<sup>2</sup>)
- 每個 index i，往左和往右，會用掉 n 次運算，所以總共 n<sup>2</sup> 次運算: O(n<sup>2</sup>)

#### Space: O(1)

---

## 優化暴力法

可以觀察到每個 height[i] 都要做一次分別往左往右找最高點  
是重覆的行為

可以先由左往右跑一次迴圈，記錄每個 height[i] 往左的最高點  
leftHeight[i] = Math.Max(leftHeight[i-1], height[i])

也由右往左跑一次迴圈，記錄每個 height[i] 往右的最高點   
rightHeight[i] = Math.Max(rightHeight[i+1], height[i])

再計算 height[i] 能容納多少雨量

### 複雜度

#### Time: O(n)
- 遍歷 height，計算 leftHeight: O(n)
- 遍歷 height，計算 rightHeight: O(n)
- 遍歷 height，計算 height[i] 能容納多少雨量: O(n)

#### Space: O(n)
- leftHeight 大小: O(n)
- rightHeight 大小: O(n)

---

## Ver1 - Stack

看了提示說用 Stack，我自己想出的方法，事後才知道這叫單調棧(Monotonic Stack)，但我想的方法又跟單調棧的解法不一樣

在由左往右的過程中，height[i] 往左的最高點很好找  
難的是往右的最高點，就使用 Stack 來記錄  

Stack 存放 index，且越接近頂端的元素，高度就越高  
Stack 的初始化方式為為由右往左，當 height[i] 比左右兩邊都高，也比 Stack 的頂端高時，就放入 Stack  

接著就可以由左往右計算每個 height[i] 能容納多少雨量  
在每個 i 也要重新計算左邊最高點，如果 i 等於 Stack 的頂端元素，就把 Stack pop，重取一個右邊最高點

### 複雜度

#### Time: O(n)

#### Space: O(n)

---

## Ver2 - Monotonic Stack - 單調棧

解法同 [Solution0084](../Solution0051_0100/Solution0084.md)，不過是遞減形式的單調棧

使用 Stack，儲存 index，越往頂端，height[i] 則越低，形成遞增形式的單調棧  

遍歷 height，假設當前 index 為 i，且假定 Stack 的頂端元素是 curr
- 如果 height[i] <= height[curr]
  - Stack.Push(i)  
- 如果 height[i] > heights[curr]，代表 curr 已各在左右找到第一個比它高的高度
  - 如果 stack 內數量不足 2，無法容納雨水
    - Stack.Pop()
    - 更新 curr
  - 如果 stack 內數量 >= 2，可容納雨水
    - curr = Stack.Pop()
    - left = Stack.Peek()
    - right = i
    - minHeight = Min(height[left], height[right])
    - result += (minHeight - height[curr]) * (right - left -1)
    - 更新 curr
    - 重覆上述過程直到 heights[i] <= heights[curr] 或是 stack 沒有元素為止
  - Stack.Push(i)  

### 複雜度

#### Time: O(n)
- 寫出來會發現很多層迴圈，不過 height 每個元素只會被放入 stack 一次，且取出時才會計算以它為基準的容納雨水量，所以是 n 次運算: O(n)

#### Space: O(n)
- Stack 最多儲的元素: O(n)