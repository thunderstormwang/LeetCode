# Solution0239 Sliding Window Maximum

## 暴力法

每移動一個位置, 即比較 k 個元素的最大值

### 複雜度

#### Time: O(n * k)

#### Space: O(1)

---

## Multi Set

C# 沒有像 C++ 的 multiset 的資料結構  
一種有排序且允許重覆元素存在的集合  
實現方式為 balanced binary search tree  
挿入或刪除元素都是 O(log(n))

#### Time: O(n * log(k))

#### Space: O(k)

---

## Monotonic Queue

在 C# 寫這題好煩，要自己做資料結構

C# 沒有 C++ 的 deque(Double-Ended Queue)  
LinkedList 最接近  
或是自己用 array 實現

保持 queue 裡的元素是由小到大  
移除元素從頭部移除  
新增元素從底部加入，在加入新元素之前，先將所有小於新元素的底部元素都移除

### 複雜度

#### Time: O(n)

#### Space: O(k)