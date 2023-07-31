# Solution0023 Merge k Sorted Lists

## Ver1 - Pritority Queue

用內建的資料結構 priority queue，也就是 min heap

result 為合併後的 ListNode  
queue 放 ListNode，並將所有 lists 的第一個元素放入 queue  

每次從 queue 取出的元素都會是當下最小的節點，把它接到 result 的最後面，然後把被取出的元素的下一個節點放入 queue  
重覆上述過程直到 queue 沒有元素為止

### 複雜度
- lists 數目有 k 個
- lists[i] 平均有 n 個元素

#### Time: O(n * k * log(k))
- 每放入一個元素都要做 heapify，lists[i] 有 n 個元素，list 一共有 k 個: O(n * k * log(k))

#### Space: O(k)
- queue 最多放 k 個元素: O(k)

---

## Ver2 - 兩兩 merge

第 0, 1 個 list 合併後變成第 0 個 list  
第 2, 3 個 list 合併後變成第 1 個 list  
...  
第 k-1, k 個 list 合併後變成第 k/2 個 list  

...  

重覆上述過程式直到 list 剩 1 個

### 複雜度

#### Time: O(n * k * log(k))
第一次合併後，list 長度 2n，共有 k/2 -> k * n  
第二次合併後，list 長度 4n，共有 k/4 -> k * n  
...  

合併次數為 log(k)，所以總共為 O(n * k * log(k))

#### Space: O(k)
- 暫存的 list 陣列長度最長有 k/2 個: O(k)