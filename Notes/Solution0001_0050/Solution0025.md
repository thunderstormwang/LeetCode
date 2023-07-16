# Solution0020 Reverse Nodes in k-Group

## Ver1

其實不難，一樣要細心，確認指針是否指到正確的地方

使用快慢指針，一開始都在 dummyNode 上

當快指針先走 k 個節點  
那麼 slow.next 到 fast 就是這次要反轉的所有節點  

令 curr = slow.next  
令 tail = slow.next  
slow.next = fast.next 且 fast.next = null，斷開要被反轉的所有節點  
讓 curr 的每個節點都插在 slow.next  
都反轉完成後，
令 fast = tail  
令 slow = tail  
再讓 fast 往 k 個節點前進

### 複雜度

#### Time: O(n)
- 需要遍歷所有節點: O(n)

#### Memory: O(1)