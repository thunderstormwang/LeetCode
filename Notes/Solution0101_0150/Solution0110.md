# Solution0110 Balanced Binary Tree

不難，不過在定義那邊卡住了  

一個 binary tree 的 Depth 和 Height 是相同的，也等同於該 tree 的 root node 的 height  

而每個節點的 depth 和 height 則會不同  
Depth 是算從 root 節點到目標節點最長要經過幾個節點
- 若 root 為空簡點，則 root 的 Depth 為 0
- 若該 tree 只有 root 一個節點，則 root 的 Depth 的為 1  

Height 是算從目標節點到 leaf node 最長要經過幾個節點，leaf node 的 Height 則為 1
- 若 root 為空簡點，則 root 的 Height 為 0
- 若該 tree 只有 root 一個節點，則 root 的 Height 的為 1  

## Ver1 - Depth First Search 計算高度

在考慮怎麼回傳
- 子樹是否為平衡子樹
- 子樹高度

有點卡，在想能否只回傳其中一個就行，答案是兩個都要回傳，才能在每個節點做正確的判斷

遞迴 root.left  
遞迴 root.right  

當符合以下條件
- 左子樹為平衡樹
- 右子樹為平衡樹
- 左子樹和右子樹的高度差 <= 1

該節點才視作平衡的子樹節點

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)

---

## Ver2 - Depth First Search 計算深度

改計算深度

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)