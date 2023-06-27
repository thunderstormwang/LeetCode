# Solution0104 Maximum Depth of Binary Tree

定義與 [Solution0110](Solution0110.md) 相同

## Ver1 - Depth First Search

用 postorder 的順序做 DFS，遍歷所有節點  
可用遞迴的方法  

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)

---

## Ver2 - Breadth First Search

用 queue 做 BFS，逐層遍歷所有節點

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- queue 最多放 n 個節點: O(n)