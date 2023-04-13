# Solution0084

## 暴力法

在每個 height<sub>i</sub> 往左找第一個比它小的高度，也往右找找第一個比它小的高度  
如此就找到 height<sub>i</sub> 的最大寬度，也就能算出矩形面積  

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(1)

---

## 單調棧

使用 Stack，儲存 index，越往頂端，index 對應的高度越高  

比較 height<sub>i</sub> 和 Stack 的頂端元素對應到的高度
- height<sub>i</sub> >= Stack 的頂端元素對應到的高度
  - Stack.Push(i)  
- height<sub>i</sub> < Stack 的頂端元素對應到的高度，
  - 代表 Stack 的頂端元素找到右邊第一個比它低的高度，而左邊第一個比它低的高度就是 它的下一個元素加 1，那就可以計算矩形面積了
  - 此過程持續到 height<sub>i</sub> >= Stack 的頂端元素對應到的高度 為止

### 複雜度

#### Time: O(n)

#### Space: O(n)

---