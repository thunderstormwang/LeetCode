# Solution0042

我喜歡這題, 很容易就想到暴力法怎麼解, 然後再去想該怎麼優化

## 暴力法

在每個 height<sub>i</sub> 分別往左往右找最高點  
再計算該點能容納多少雨量

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(1)

---

## 優化暴力法

在每個 height<sub>i</sub> 都要做一次分別往左往右找最高點  
是重覆的行為

可以先由左往右跑一次迴圈，記錄每個 height<sub>i</sub> 往左的最高點   
leftHeight[i] = Math.Max(leftHeight[i-1], height[i])

也由右往左跑一次迴圈，記錄每個 height<sub>i</sub> 往右的最高點   
rightHeight[i] = Math.Max(rightHeight[i+1], height[i])

再計算 height<sub>i</sub> 能容納多少雨量

### 複雜度

#### Time: O(n)

#### Space: O(n)

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

## Stack Ver2

使用 Stack，儲存 index，越往頂端，index 對應的高度越低  

比較 height<sub>i</sub> 和 Stack 的頂端元素對應到的高度
- height<sub>i</sub> <= Stack 的頂端元素對應到的高度
  - Stack.Push(i)  
- height<sub>i</sub> > Stack 的頂端元素對應到的高度，
  - 代表 Stack 的頂端元素找到右邊第一個比它高的高度，而左邊第一個比它高的高度就是 它的下一個元素，那就可以能容納的雨水容量了
  - 能容納的雨水容量的寬度 = 右邊 - 左邊 - 1
  - 能容納的雨水容量的高度 = Math.Min(右邊高度, 左邊高度) - height<sub>i</sub>
  - 此過程持續到 height<sub>i</sub> <>= Stack 的頂端元素對應到的高度 或是 Stack 只剩一個元素為止

### 複雜度

#### Time: O(n)

#### Space: O(n)