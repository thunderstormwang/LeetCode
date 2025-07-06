# Solution0323 Number of Connected Components in an Undirected Graph

## Depth First Search

建立鄰接表，因為是無向圖，要分別為兩個節點增加鄰接點  
建立 visited 陣列  
用變數 result 記錄孤島數，初始為 0

輪詢每個節點<sub>i</sub>
- 如果 visited[節點<sub>i</sub>] = 1，跳過
- 如果 visited[節點<sub>i</sub>] = 0
  - 呼叫遞迴
  - result++

遞迴
- 如果 visited[節點<sub>i</sub>] = 1，回傳
- 如果 visited[節點<sub>i</sub>] = 0
  - visited[節點<sub>i</sub>] = 1
  - 從鄰接表找出所有與節點<sub>i</sub> 相鄰的節點<sub>j</sub>，輪詢每個節點<sub>j</sub>
    - 如果 visited[節點<sub>j</sub>] = 1，跳過
    - 如果 visited[節點<sub>j</sub>] = 0，呼叫遞迴

result 即為答案

### 複雜度
- n 個節點
- m 個無向邊數量

#### Time: O(n<sup>2</sup>)
- 建立鄰接表: O(m)
- 最多遞迴 n 層，每次遞迴最多輪詢 n-1 個節點: O(n<sup>2</sup>)

#### Space: O(m+n)
- 建立鄰接表: O(m)
- 最多遞迴 n 層: O(n)

相加後取最大: O(n + m)

---

## Breadth First Search

建立鄰接表，因為是無向圖，要分別為兩個節點增加鄰接點  
建立 visited 陣列  
用變數 result 記錄孤島數，初始為 0

輪詢每個節點<sub>i</sub>
- 如果 visited[節點<sub>i</sub>] = 1，跳過
- 如果 visited[節點<sub>i</sub>] = 0
  - 將節點<sub>i</sub> 放入 queue
  - 輪詢這層 queue 中所有元素
    - 從 queue 中取出元素，節點<sub>node</sub>
    - 將 visisted[節點<sub>node</sub>] 改為 1
    - 從鄰接表找出所有與節點<sub>node</sub> 相鄰的節點<sub>j</sub>，輪詢每個節點<sub>j</sub>
      - 如果 visited[節點<sub>j</sub>] = 1，跳過
      - 如果 visited[節點<sub>j</sub>] = 0，將 節點<sub>j</sub> 放入 queue
  - result++

result 即為答案

### 複雜度
- n 個節點
- m 個無向邊數量

#### Time: O(n<sup>2</sup>)
- 建立鄰接表: O(m)
- 每個節點最多被放入 queue 一次，從 queue 取出節點後最多輪詢 n-1 個節點: O(n<sup>2</sup>)

#### Space: O(m+n)
- 建立鄰接表: O(m)
- queue 最多放 n 個節點: O(n)

相加後取最大: O(m + n)

---

## Union Find

初始將每個節點視為孤島，若發現可合併，就將孤島的數量減 1

建立 Dicitonary parent，初始將 parent[節點<sub>i</sub>] = 節點<sub>i</sub>  
用變數 result 記錄孤島數，初始為 n

輪詢每條 edge  
edge 相連的兩個節點，節點<sub>0</sub>, 節點<sub>1</sub>  
若 parent[節點<sub>0</sub>] != parent[節點<sub>1</sub>] 即執行合併，並將 result--

### 複雜度
- n 個節點
- m 個無向邊數量

#### Time: O(n * m)
- 輪詢每個 edge，每條 edge 的節點找 parent 最多可能要找 n-1 的節點: O(n * m)

#### Space: O(n)
Dicitonary parent 會有 n 個節點: O(n)