# Solution0124 Binary Tree Maximum Path Sum

## Ver1 - Depth First Search

Ver1 是自己想出來的

每個節點要回傳兩種情況
- 包含本身節點的最大 path sum
- 不包含本身節點的最大 path sum

所以每個節點要先從左右子樹取得以下情形
- 左子樹中包含 currNode.Left 節點的最大 path sum -- Left-1
- 左子樹中不包含 currNode.Left 節點的最大 path sum -- Left-2
- 右子樹中包含 currNode.Right 節點的最大 path sum  -- Right-1
- 右子樹中不包含 currNode.Right 節點的最大 path sum -- Right-2

包含本身節點的最大 path sum 有以下情形，取最大
- 只包含 currNode 本身
- currNode 加上 Left-1
- currNode 加上 Right-1

不包含本身節點的最大 path sum 有以下情形，取最大
- 左子樹中不包含 Left-2
- 右子樹中不包含 Right-2
- 左子樹中包含 Left-1
- 右子樹中包含 Right-1

因為節點的值在 -1000 ~ 1000 之間，所以當當前節點為 null 時，必須回傳 -1001 以上，才不會反而被選中

遞迴結束後，再決定一次是否要包含 root 的 path sum，即為答案

#### Time: O(n)
- 需要遍歷每個節點 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)

---

## Ver2 - Depth First Search

解答還是比較精簡，也不好想，需要經過思考  
同時在當前節點為 null 時，可以回傳 int.MinValue

左子樹的最大 path sum = Max(0, 左子樹的最大 path sum)  
右子樹的最大 path sum = Max(0, 右子樹的最大 path sum)

只有在當前節點才能計算 currNode + 左子樹的最大 path sum + 右子樹的最大 path sum，  
但此計算結果不能當作遞迴結果回傳給上層，因為上層只能拿 currNode + Max(左子樹的最大 path sum, 右子樹的最大 path sum)作計算，這才符合題意

### 複雜度

#### Time: O(n)
- 需要遍歷每個節點 n 次: O(n)

#### Space: O(n)
- queue 最多放 n 個元素: O(n)