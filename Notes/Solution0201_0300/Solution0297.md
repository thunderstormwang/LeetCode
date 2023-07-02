# Solution0297 Serialize and Deserialize Binary Tree

## Depth First Search

本來想說照 [Solution0105](../Solution0101_0150/Solution0105.md) 的做法，用出 preorder 和 inorder 的順序各找一個字串，寫完才發現有盲點，binary tree 的所有節點的值要是唯一才可以這樣用，例如 inorder [3, 2, 4, 3] 就無法這樣用，無法反解回原本的 tree


### 複雜度

#### Time: O()

#### Space: O()