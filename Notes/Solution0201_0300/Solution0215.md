# Solution0215 Kth Largest Element in an Array

## Ver1 - 排序

由小到大排序後，從右邊取第 k 個數字

### 複雜度

#### Time: O(n * log(n))

#### Space: O(1)

---

## Ver2 - Quick Selection排序

用類似 quick sort 的方式，可以由大排到小  
大於等於 pivot 的元素放左側  
小於 pivot 的元素放右側  

如果 pivot 的位置大於 k - 1，那下次從 left ~ pivot - 1 找起  
如果 pivot 的位置小於 k - 1，那下次從 pivot + 1 ~ right 找起  
直到 pivot = k - 1

### 複雜度

#### Time: O(n)

#### Space: O(1)