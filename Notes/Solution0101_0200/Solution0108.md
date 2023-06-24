# Solution0108 Convert Sorted Array to Binary Search Tree

## Ver1 - 遞迴

用類似 binary search 的方式建造 tree

當遞迴呼叫到
- start = end
- end = start = 1
- end - start = 2

建造 tree，並回傳 root

其它情況則令 cneter = (start + end) / 2，root 的值等於 nums[center]  
root 的左子樹交由遞迴 (start, center - 1)  
root 的右子樹交由遞迴 (center + 1, end)  

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)

---

## Ver2 - 遞迴

同 Ver1

當遞迴呼叫到
- start > end，回傳 null
- end = start，回傳當前唯一的節點

其它情況則令 cneter = (start + end) / 2，root 的值等於 nums[center]  
root 的左子樹交由遞迴 (start, center - 1)  
root 的右子樹交由遞迴 (center + 1, end)  

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)