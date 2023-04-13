# Solution0496

## 暴力法

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Memory: O(1)

---

## Stack

跟 [Solution0739](Solution0739.md) 類似，較複雜一些

用 stack 找出 nums2 裡下一個較大元素的位置後，將它們儲存在 hash 裡，讓 nums1 可以用 O(1) 的代價找到對應的元素

### 複雜度

#### Time: O(n+m)

#### Memory: O(m)