# Solution0098 Validate Binary Search Tree

## Ver1

用 inorder 的順序把所有節點放到 list  
再檢查 list 是否有依照由小到大的方式排列  

### 複雜度

#### Time: O(n)
- 要遍歷每個節點，最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)
- list 的大小: O(n)

---

## Ver 2

限縮每個節點的值的範圍  
root 的範圍會是 min < root < max  
則遞迴到 root.left 的可容許範圍會是 min < root.left < root  
則遞迴到 root.right 的可容許範圍會是 root < root.right < max

因為 testcase 裡有 int.MaxValue，將 min 預設為 long.MinValue, max 預設為 long.MaxValue
  
### 複雜度

#### Time: O(n)
- 要遍歷每個節點，最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)