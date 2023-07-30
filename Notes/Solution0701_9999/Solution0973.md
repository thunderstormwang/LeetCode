# Solution0973 K Closest Points to Origin

## 排序

由小到大排序後，取前 k 個座標

### 複雜度

#### Time: O(n * log(n))

#### Space: O(1)

---

## Ver1 - Pritority Queue

用內建的資料結構 priority queue，其內部是用 heap 去實現

將 queue 保持在 k 個元素數目，超過的即移除

### 複雜度

#### Time: O(n) --?

#### Space: O(n)

---

## Ver2 - Quick Selection

跟 [Solution0215](../Solution0201_0300/Solution0215.md) 一樣的做法

用類似 quick sort 的方式，由小排到大  
小於等於 pivot 的元素放左側  
大於 pivot 的元素放右側  

當 pivot 正好在 k - 1 時，即代表找到前 k 個距離原點最近的座標

### 複雜度

#### Time: O(n) --?

#### Space: O(1)