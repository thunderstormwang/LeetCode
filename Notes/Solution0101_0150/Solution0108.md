# Solution0108 Convert Sorted Array to Binary Search Tree

Ver1 為自己想的方式，Ver2 為解答，果然較簡潔

## Ver1 - 遞迴 Prefix

用類似 binary search 的方式建造 tree

呼叫遞迴直到
- start = end
- end = start = 1
- end - start = 2

建造 tree，並回傳 root

其它情況則令 center = (start + end) / 2，root 的值等於 nums[center]  
遞迴 root.left，start 不變，end = center - 1  
遞迴 root.right，start = center + 1，end 不變  

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)

---

## Ver2 - 遞迴 Prefix

同 Ver1，果然還是解答較簡潔

當遞迴呼叫到
- start > end，回傳 null
- end = start，回傳當前節點

其它情況則令 center = (start + end) / 2，root 的值等於 nums[center]  
遞迴 root.left，start 不變，end = center - 1  
遞迴 root.right，start = center + 1，end 不變   

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)