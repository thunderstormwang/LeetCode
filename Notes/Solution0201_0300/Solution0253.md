# Solution0253 Meeting Rooms II

這題想很久，原因我沒想出 generalize 的解法，自然連程式也寫不出來  

可以這麼想，將 interval 依照開始時間、結束時間排序後，  
然後建立佔用 inerval 的列表，此列表需要照 interval 的結束時間做排序  
每輪詢一個 intgerval，將列表中結束時間早於該 interval 的開始時間給移除，代表會議室空出來，可以給下個會議使用  
計算此列表佔用的最大空間數即是答案

可以這麼想：輸入 [1, 4], [2, 3], [3, 5]  

輪詢到 [1, 4]  
加入新元素進列表並經過排序後: [1, 4]

輪詢到 [2, 3]  
加入新元素進列表並經過排序後: [2, 3], [1, 4]

輪詢到 [3, 5]  
移除結束時間早於 3 的元素後，列表 : [1, 4]  
加入新元素進列表並經過排序後: [1, 4], [3, 5]

過程中，列表最多佔用空間為 2，所以答案為 2

有把問題 generalize 出來後，會發現以下解法都是同樣的做法

## Two Pointer

建立二個陣列
- 起始時間陣列
- 結束時間陣列
將兩個陣列分別做排序  

分別對兩個陣列建立指標，i 對於起始時間，j 對於結束時間，皆初始化為 0  
輪詢陣列
- 如果 起始時間[i] > 結束時間[j]
  - 佔用的會議室數量加 1，且 i + 1
- 如果 起始時間[i] <= 結束時間[j]
  - 佔用的會議室數量加 1，且 j + 1

佔用的會議室數量的最大值即為答案

### 複雜度

#### Time: O(n * log(n))
- 起始時間排序: O(n * log(n))
- 結束時間排序: O(n * log(n))
- 輪詢元素: O(n)

取最大項: O(n * log(n))

#### Space: O(n)

---

## PriorityQueue

C# 到 Net 6.0 才有此資料結構  
實作方式 MinHeap

輪詢 interval，如果 interval[i] 的開始時間大於 queue 中第一個元素的結束時間，代表有會議室空出來，就把第一個元素從 queue 中取出  
將 interval[i] 放入 queue 中  

queue 佔用的空間的最大數量即為答案

### 複雜度

#### Time: O(n * log(n))
- 排序: O(n * log(n))
- 塞入元素 priority queue 要 log(n)，且一共 n 個元素: O(n * log(n))

取最大項: O(n * log(n))

#### Space: O(n)

---

## SortedList

輪詢 interval，如果 interval[i] 的開始時間大於 list 中第一個元素的結束時間，代表有會議室空出來，就把第一個元素從 list 中取出  
將 interval[i] 放入 list 中  

list 佔用的空間的最大數量即為答案

### 複雜度

#### Time: O(n * log(n))
- 排序: O(n * log(n))
- 塞入元素 sorted list 要 log(n)，且一共 n 個元素: O(n * log(n))

取最大項: O(n * log(n))

#### Space: O(n)