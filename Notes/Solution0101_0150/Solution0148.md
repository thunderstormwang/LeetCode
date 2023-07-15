# Solution0148 Sort List

一開始選用 insertion sort，結果會 TLE

照題目的挑戰用空間 O(1) 會很不好做

## Ver1 - Merge Sort - Recursive

能 n * log(n) 的排序法有 quck sort, merge sort, heap sort  

網路上查  
quck sort 應該也可以  
heap sort 不知道能不能做到  

不過用遞迴做 merge sort 是無法達成空間 O(1) 的

### 複雜度

#### Time: O(n * log(n))

#### Space: O(log(n))
- 最多遞迴 log(n) 層: O(log(n))

---

## Ver2 - Merge Sort - Iterative

用迭代的方式才能做到空間 O(1)，但頗難寫

算出 list 長度 n
len 從 1 開始，在 len < n 時持續跑 while 迴圈
- 在 head 不為 null 的情況下，持續跑 while 回圈
  - list1 = head
  - list2 = 從 list1 切出 len 個節點後的第一個節點
  - temp = 從 list2 切出 len 個節點後的第一個節點
  - mergeResult = Merge(list1, list2)
  - head 的前一個節點的 next 指向 mergeResult 的第一個節點
  - mergeResult 的最後一個節點的 next 指向 temp
  - head = temp
- len *= 2

### 複雜度

#### Time: O(n * log(n))

#### Space: O(1)