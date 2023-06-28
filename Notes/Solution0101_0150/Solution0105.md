# Solution0105 Construct Binary Tree from Preorder and Inorder Traversal

## 遞迴

root 節點在 preorder 一定是第一個，然後在 inorder 尋找 root 的位置 center，  
inorder 在 center(不包含)以左的都是左子樹  
inorder 在 center(不包含)以右的都是右子樹  
從 inorder 推出左右子樹的長度後，就可以計算在 preorder 左子樹和右子樹的範圍，並且要注意長度和 index 之間轉換  

例如: prderorderStart, preorderEnd, inorderStart, inorderEnd  
root 節點會在 preorder[prderorderStart]  
然後尋找 root 節點在 inorder 的位置 cneter  
則 inorder 中 inorderStart <= i <= center - 1 是左子樹  
則 inorder 中 cneter + 1 <= i <= inorderEnd 是右子樹  
則 preorder 中 preorderStart + 1 <= i <= preorderStart + center - inorderStart 是左子樹  
則 inorder 中 preorderEnd - (inorderEnd - center)  <= i <= preorderEnd 是右子樹  

就可以一路往下遞迴到剩一個節點，再往上建立出整個 binary tree

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)