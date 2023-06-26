# Solution0285 Inorder Successor in BST

我第一個想法又是跟 [Solution0098](../Solution0051_0100/Solution0098.md) 一樣用 inorder 的方式取出 list  
再從 list 中找符合的元素  
這方法是可行，但完成沒用到 binary search tree 的特性，就沒這樣做，但也想不到其它做法  

## Ver1 - Inorder 並傳遞前一個節點

有隱約想到在遍歷每個節點時，把前一個節點傳下去  
但嫌麻煩，沒往下做  

用 inorder 的方式遍歷節點，並將當前節點傳下去，作為下一個節點的 pre  
遞迴左子樹時，不更動 pre 就傳給左子樹，因為 root 不是 root.left 的前一個  
如果當前節點檢查到 pre = p 時，當前節點即為答案  
遞迴右子樹時，pre 要用當前節點傳給右子樹，因為 root 不是 root.right 的前一個  

### 複雜度

#### Time: O(n)
- 最差情況下，要遍歷每個節點，最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)

---

## Ver 2

善用 binary search tree 的特性，可以不用遍歷每個節點  
如果 root.val > p.val，那麼 p 就會在左子樹中，且 root 有可能會是 successor，所以就遞迴左子樹，如果左子樹回傳找不到 successor，那麼當前 root 就是那個 successor
如果 root.val <= p.val，那麼 p 就會在右子樹中，且 root 不會是 successor，所以就遞迴右子樹，直接回傳右子樹找到的結果即可

### 複雜度

#### Time: O(n)
- 如果是 complete tree，會是 log(n)，最差情況下，需要遍歷每個節點，最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)