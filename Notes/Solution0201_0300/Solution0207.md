# Solution0207

有想到是找 cycle，不過看到輸入卻想不到怎麼下手  
原來要先從建立出鄰接表開始做  

## Ver1 - Topological Sort - Depth First Search 版

建立鄰接表，記錄修完課程A後，可以繼續修的其它課程  
建立 visited 陣列
- 0: 未訪問過
- 1: 訪問中
- 2: 已訪問過

對每個課程開始做 Depth First Search
- 如果 visited[課程<sub>i</sub>] 為 2，已訪問過，回傳 true
- 如果 visited[課程<sub>i</sub>] 為 1，探測到循環，回傳 false
- 如果 visited[課程<sub>i</sub>] 為 0
  - 將 visited[課程<sub>i</sub>] 改為 1
  - 從鄰接表找出課程<sub>i</sub> 所有接續課程<sub>j</sub>，對每個課程<sub>j</sub> 都做 Depth First Search
  - 將 visited[課程<sub>i</sub>] 改為 2
  - 回傳 false

順帶一提，可用 stack 記錄碰到 visited[課程] = 2，等遞迴結束後，將 stack 依序取出即可當作修課順序

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

## Ver2 - Depth First Search

跟 Ver1 差別在不使用 Topological Sort，單純使用 Depth First Search，所以有重覆的計算  
如果能回到原點，代表有循環  
如果每個點都不能回到原點，代表可修完所有的課

### 複雜度
- n 個節點
- m 個有向邊的數量

#### Time: O(n<sup>2</sup> + m)
- 建立鄰接表: O(m)
- 在每個節點都做 Depth First Search，最多可能遞迴到 n 層: O(n<sup>2</sup>)

相加後取最大: O(n<sup>2</sup> + m)

#### Space: O(n + m)
- 要建立鄰接表: O(m)
- 最多遞迴 n 層: O(n)

相加後取最大: O(n + m)

---

## Ver3 - Topological Sort - Breadth First Search 版

除了要計算鄰接表，也要計算每個課程的 inDegree(前置課程的數量)  
然後將 inDegree 為 0 的課程加入 queue，從這些課程開始 traverse

從 queue 中取出課程<sub>i</sub>，從鄰接表找出所有課程<sub>i</sub> 有指向的課程<sub>j</sub>，將所有課程<sub>j</sub> 的 inDegree 的數量都減1，如果有某個課程<sub>j</sub> 的 inDegree 也變成 0 的節點，就加入 queue  

最終 queue 的元素都取出後，如果加入 queue 的數量跟所有課程數量相等，就代表沒有循環，可以修完所有課程，反之若有放不進 queue 的課程，就代表那些課程之間有循環

順帶一提，從 queue 中取出的順序即可當作修課順序

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