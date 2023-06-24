# Solution0226 Invert Binary Tree

接受人有當機的時候，即使大神也有可能寫不出來這題

## Ver1 - Depth First Search Recursive

遞迴呼叫每個節點
- 將左子樹傳入遞迴
- 將右子樹傳入遞迴
- 將左右子樹對調

順序不重要

### 複雜度

#### Time: O(n)
- 最多遞迴 n 個節點: O(n)

#### Space: O(n)
- 最多遞迴 n 個節點: O(n)

---

## Ver2 - Depth First Search Iterative

同 Ver1，改用 stack

### 複雜度

#### Time: O(n)
- 每個節點都被輪詢過: O(n)

#### Space: O(n)
- stack 最多放 n 個節點: O(n)

---

## Ver2 - Breadth First Search

改用 queue

### 複雜度

#### Time: O(n)
- 每個節點都被輪詢過: O(n)

#### Space: O(n)
- queue 最多放 n 個節點: O(n)