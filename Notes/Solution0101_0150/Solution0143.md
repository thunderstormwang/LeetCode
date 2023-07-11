# Solution0143 Reorder List

## Ver1

linked list 的題目似乎都考驗細心

想法不難，大方法就是
- 將 list 拆成 firstHalf 和 secondHalf
- 反轉 secondHalf
- 交錯放入 firstHalf 和 secondHalf

過程中指標很多，容易寫錯，考驗細心

### 複雜度

#### Time: O(n)
- 將 list 拆一半，需要遍歷 n 個節點: O(n)
- 反轉 secondHalf，需要遍歷 n/2 個節點: O(n)
- 交錯放入 firstHalf 和 secondHalf: O(n)

#### Space: O(1)