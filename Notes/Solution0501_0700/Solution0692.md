# Solution0692 Top K Frequent Words

## Pritority Queue

遍歷 words，計算每個字串的出現次數，存在 dict  
將 dickt 的每一對 key, value 放入 Priority Queue  
當 Priority Queue 的數目超過 k 個後，將出現次較少或是出現次數相等但字母順序排得較後面的字串給移出 queue，在 C# 需要寫自訂的 Comparer

### 複雜度
- words 一共有 n 個

#### Time: O(n * log(k))
- 遍歷陣列: O(n)
- Priority Queue 最多有 k 個元素，所以 heapify 會耗費 log(k)，然後 dict 最多有 n 字串: O(n * log(k))

#### Space: O(n)
- dict 最多放 n 個元素: O(n)
- Priority Queuedict 最多放 k 個元素: O(k)

相加後取最大: O(n)