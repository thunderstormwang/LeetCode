# Solution0285 Inorder Successor in BST

用 inorder 的都方式走完所有節點，把經過的節點依序放在 list  
再從 list 找到符合的值  
這方法可行，但完成沒用到 binary search tree 的特性  

## Ver1

有隱約想到用遞迴，把前一個節點傳下去  
但嫌麻煩，沒往下做

用 inort 和遞迴的方式輪詢節點，並一路將 pre 傳下去  
當往左邊走時，pre 不會變，因為 root 不是 root.left 的前一個  
當往右邊走時，pre 要用 root 傳下去，因為 root 有可能是 root.right 的下一個  
當走到第一個 pre = p 的節點時，該節點即為答案

### 複雜度

#### Time: O(n)
- 最差情況下，每個節點都要拜訪過，最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)

---

## Ver 2

善用 binary search tree 的特性  
如果 root.val > p.val，那麼 p 就會在左子樹中，所以往左子樹找去，且 root 有可能會是 successor，如果左子樹回傳找不到 successor，那該 root 就是那個 successor
如果 root.val <= p.val，那麼 p 就會在右子樹中，所以往右子樹找去，且 root 不會是 successor，回傳右子樹找到的結果即可

### 複雜度

#### Time: O(n)
- 如果是 complete tree，會是 log(n)，最差情況下，每個節點都要拜訪過，最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)