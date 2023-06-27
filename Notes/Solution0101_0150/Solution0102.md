# Solution0102 Binary Tree Level Order Traversal

## Ver1 - Breadth First Search

用 queue 做 BFS，逐層遍歷所有節點

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)

---

## Ver1 - Depth First Search - Inorder

用 inorder 的順序做 DFS，遍歷所有節點  
可用遞迴的方法，並傳入深度，讓每個節點知道該將自己放在第幾個 list

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)

---

## Ver3 - Depth First Search - Preorder

同 Ver2  
改用 preorder 的順序做 DFS，遍歷所有節點  

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)