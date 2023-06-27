# Solution0543 Diameter of Binary Tree

## 遞迴

看不是很懂這題，研究出每個節點的 diameter 等於左子樹深度 加上 右子樹深度，所以要算出每個節點的 diameter，然後求出最大值

用 postorder 順序遍歷所有節點
- 左子樹的 diameter
- 右子樹的 diameter
- 左子樹深度 加上 右子樹深度

如此一路把求得的最大的 diameter 往上傳

### 複雜度

#### Time: O(n)
- 需要遍歷所有節點: O(n)

#### Space: O(n)
- 最多遞迴 n 層: O(n)