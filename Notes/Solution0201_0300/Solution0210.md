# Solution0210

## Ver1 - Topological Sort - Depth First Search 版

同 [Solution0207](Solution0207.md) 作法  
用 stack 記錄碰到 visited[課程] = 2，等遞迴結束後，將 stack 依序取出即可當作修課順序

### 複雜度
- n 個節點
- m 個有向邊的數量

#### Time: O(n + m)
- 建立鄰接表: O(m)
- 最多遞迴 n 層: O(n)

相加後取最大: O(n + m)

#### Space: O(n + m)
- 要建立鄰接表: O(m)
- 要建立 visit 陣列，容量為 n: O(n)
- 最多遞迴 n 層: O(n)

相加後取最大: O(n + m)

---

## Ver2 - Topological Sort - Breadth First Search 版

同 [Solution0207](Solution0207.md) 作法  
從 queue 中取出的順序即可當作修課順序

### 複雜度
- n 個節點
- m 個有向邊的數量

#### Time: O(n + m)
- n 個節點, m 個有向邊的數量
- 建立鄰接表: O(m)
- 建立 inDegree: O(m)
- 初始找 inDegree 數量為 0 的節點: O(n)
- 每個節點只會被放入 queue 一次，且跑鄰接表不會超過 m: O(n + m)

相加後取最大: O(n + m)

#### Space: O(n + m)
- 建立鄰接表: O(m)
- 建立 inDegree: O(n)
- queue 最多放入 n 個節點: O(n)

相加後取最大: O(n + m)