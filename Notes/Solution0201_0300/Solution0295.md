# Solution0295 Find Median from Data Stream

好難...一開始想不到該用什麼資料結構，  
看懂解答想法後還是一直寫錯

## Pritority Queue

只有一個 Priority Queue 的話，在 FindMedian 要 Dequeue 特定數量的元素，然後又要 Enqueue 回去，會 TLE

需要用兩個 Priority Queue，smallQueue 放較小的數字，為 max heap；largeQueue 放較大的數字，為 min heap。  
如此一來，兩個 queue 的最頂的元素就是中間的元素
- 當兩個 queue 的元素數目不相等時，取較多的那個 queue 的 Peek() 就是 median
- 元素數目相等時，取兩個 queue 的 Peek() 除以 2 就是 median

因為 C# 的 priority queue 預設是 min heap，在 num > largeQueue.Peek() 時，將 num 放入 largeQueue，反之放入 smallQueue。

保持兩個 queue 的數目 <= 1，若否，將數目較多的那個 queue 給 Dequeue 後取反向放入另一個 queue  

### 複雜度
- AddNum, FindMedian 一共有 n 個

#### Time: O(n * log(k))
- AddNum: O(log(n))
- FindMedian: O(1)

#### Space: O(n)