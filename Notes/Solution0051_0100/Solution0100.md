# Solution0100 Same Tree

## Ver1 - Depth First Search - Recursive

利用遞迴，用 inorder 的順序遍歷兩顆 binary tree

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)

---

## Ver2 - Depth First Search - Iterative

同 Ver1，改用迭代方式

### 複雜度

#### Time: O(n)
- 需要遍歷每個節點 n 次: O(n)

#### Space: O(n)
- stack 最多放 n 個元素 n 次: O(n)

---

## Ver3 - Breadth Firs tSearch

利用 queue，用 BFS 的方式遍歷所有節點

### 複雜度

#### Time: O(n)
- 需要遍歷每個節點 n 次: O(n)

#### Space: O(n)
- queue 最多放 n 個元素 n 次: O(n)