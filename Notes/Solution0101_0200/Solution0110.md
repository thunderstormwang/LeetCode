# Solution0110 Balanced Binary Tree

不難，不過在定義那邊卡住了  

一個 binary tree 的 Depth 和 Height 是相同的，但在每個節點是不同的  
Depth 是算從 root 到該節點最長要經過幾個節點，root 的 Depth 則為 0  
Height 是算從該節點到 left node 最長要經過幾個節點，left node 的 Height 則為 0

## Ver1 - Depth First Search 計算高度

在考慮怎麼回傳
- 子樹是否為平衡子樹
- 子樹高度

有點卡，在想能否只回傳其中一個就行，答案是兩個都要回傳，才能在每個節點做正確的判斷


root 的左子樹交由遞迴  
root 的右子樹交由遞迴  

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