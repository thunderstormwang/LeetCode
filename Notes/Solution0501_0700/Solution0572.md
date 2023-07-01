# Solution0101 Same Tree

## Ver1 - Depth First Search - Recursive

[Solution0100](Solution0100.md) 的變形題  

在 root 的每個節點都檢查是否 subRoot 相同

### 複雜度
- root 的節點數: n
- subRoot 的節點數: m

#### Time: O(n)
- 最差情況下，在 root 的每個節點都要重找是否與 subRoot 相同 n * m 次: O(n * m)

#### Space: O(n)
- 最多遞迴 n * m 次: O(n * m)

---

## Ver2 - Depth First Search - Iterative

同 Ver1，改用迭代方式

### 複雜度
- root 的節點數: n
- subRoot 的節點數: m

#### Time: O(n)
- 最差情況下，在 root 的每個節點都要重找是否與 subRoot 相同 n * m 次: O(n * m)

#### Space: O(n)
- stack 最多放 n * m 個節點: O(n * m)

---

## Ver3 - Breadth Firs tSearch

利用 queue，用 BFS 的方式遍歷所有節點

### 複雜度
- root 的節點數: n
- subRoot 的節點數: m

#### Time: O(n)
- 最差情況下，在 root 的每個節點都要重找是否與 subRoot 相同 n * m 次: O(n * m)

#### Space: O(n)
- queue 最多放 n * m 個節點: O(n * m)