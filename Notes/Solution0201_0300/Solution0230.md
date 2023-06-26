# Solution0230 Kth Smallest Element in a BST

## Ver1 - Inorder 轉成 list

跟 [Solution0098](../Solution0051_0100/Solution0098.md) 一樣用 inorder 的方式取出 list  
再回傳 list 的第 k 個元素  

### 複雜度

#### Time: O(n)
- 最差情況要遍歷每個節點，最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)
- list 的大小: O(n)

---

## Ver2 - Inorder 和計數

用 inorder 的方式依序遍歷每個節點，並做計數記錄在 count  
只要 count 等於 k，就回傳當前節點的值
  
### 複雜度

#### Time: O(n)
- 最差情況要遍歷每個節點，最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)