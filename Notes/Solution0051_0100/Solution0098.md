# Solution0098 Validate Binary Search Tree

## Ver1

用 inorder 的方式把所有節點放到 list  
再檢查 list 是否有依照由小到大的方式排列  

### 複雜度

#### Time: O(n)
- 每個節點都要拜訪過，最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)
- list 的大小: O(n)

---

## Ver 2

限縮每個節點的值的範圍  
將 min 預設為 long.MinValue, max 預設為 long.MaxValue

則 node.left 的可容許範圍是 min < node.left < node  
則 node.right 的可容許範圍是 node < node.right < max
  
### 複雜度

#### Time: O(n)
- 每個節點都要拜訪過，最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)