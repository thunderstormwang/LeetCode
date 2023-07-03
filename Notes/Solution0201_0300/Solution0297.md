# Solution0297 Serialize and Deserialize Binary Tree

## Ver1 - Depth First Search

本來想照 [Solution0105](../Solution0101_0150/Solution0105.md) 的做法，用出 preorder 和 inorder 的順序各找一個字串，寫完才發現有盲點，binary tree 的所有節點的值要是唯一才可以這樣用，例如 inorder [3, 2, 4, 3] 就無法這樣用，無法反解回原本的 tree

在 serialize 時，將每個節點以「,」分隔，null 的節點以「#」作代表  
[1, 2, 3, null, null, 4, 5] 用 preorder 的順序轉換成 「1,2,#,#,3,4,#,#,5,#,#」

在 deserialize 時，以 preorder 的順序反解回來

### 複雜度

#### Time: O(n)
- 最多遞迴 n 層: O(n)

#### Space: O(n)
- 最多遞迴 n 層: O(n)

---

## Ver2 - Breadth First Search

BFS 會較複雜些，需要把節點再放回 queue

在 serialize 時，將每個節點以「,」分隔，null 的節點以「#」作代表  
[1, 2, 3, null, null, 4, 5] 用 BFS 的順序轉換成 「1,2,3,#,#,4,5,#,#,#,#」

在 deserialize 時，當指定 1 的 left child 為 2，right child 為 3 後，要再將 2, 3 放入 queue，才可以往下處理 「#,#,4,5,#,#,#,#」

### 複雜度

#### Time: O(n)
- 需要遍歷每個節點: O(n)

#### Space: O(n)
- queue 最多放 n 個節點: O(n)