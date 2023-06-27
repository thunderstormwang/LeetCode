# Solution0543 Binary Tree Right Side View

## Ver1 Depth First Search

用 preorder 的順序遍歷所有節點，並把深度傳下去  
這次先遞迴右子樹再遞迴左子樹  
如果在當前節點發現 depth + 1 > list.Count，說明這是這層中最右邊的節點，把當前節點的值加進 list

### 複雜度

#### Time: O(n)
- 需要遍歷所有節點: O(n)

#### Space: O(n)
- 最多遞迴 n 層: O(n)

---

## Ver2 Breadth First Search

用 queue 作 BFS，每層 queue 的最後一個元素即為每層中最右邊的節點

### 複雜度
- tree 的高度: h

#### Time: O(n)
- 需要遍歷所有節點: O(n)

#### Space: O(n)
- queue 最多放 2<sup>h-1</sup> 個節點 < 整個 tree 的 n 個節點: O(n)