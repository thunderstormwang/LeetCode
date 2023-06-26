# Solution0235 Lowest Common Ancestor of a Binary Search Tree

## Ver1 - Recursive(遞迴)

要應用 Binary Search Tree 的特性，當作一般 binary tree 的話，會發現很難寫，在遞迴中有太多變數要回傳

當遇到第一個 root，且 root 介於 p, q 之間，該 root 是最小共同祖先  
當遇到第一個 root，且 p = root < 或 q = root，該 root 是最小共同祖先  
非以上情形，就代表 p, q 都在 root 的左邊或右邊，那就判斷該往哪邊去找  

### 複雜度

#### Time: O(n)
- 最差情況下 Binary Search Tree 的節點都分布在同一邊，例如 [1, 2, 3, 4, 5]，那最多會遞迴 n 層: O(n)

#### Space: O(n)
- 最多會遞迴 n 層: O(n)

## Ver2 - Iterative(迭代)

同 Ver1 想法，改回 Iterative 作法

### 複雜度

#### Time: O(n)
- 最差情況下，要遍歷 n 個節點: O(n)

#### Space: O(1)