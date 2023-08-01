# Solution0658 Find K Closest Elements

## Ver1 - Pritority Queue

無腦套用 priority queue，但這題的最佳解不是用 priority queue

將 queue 的數目保持在 k 個，遍歷完陣列後，還在 queue 的元素即是答案

### 複雜度

#### Time: O(n * log(k))
- 每放入一個元素都要做 heapify，一共有 n 個元素: O(n * log(k))

#### Space: O(k)
- queue 最多放 k 個元素: O(k)

---

## Ver2 - Two Pointer

left 指向最左邊  
right 指向最右邊  

哪邊與 x 的差的絕對值較大，就將那一邊的指針往內移動  
絕對值就再比大小  
比到剩 k 個元素即是答案

### 複雜度

#### Time: O(n)
- 需要遍歷陣列: O(n)

#### Space: O(1)
