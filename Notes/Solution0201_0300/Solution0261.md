# Solution0261

因為 tree 的定義是
- 不能有 cycle
- 沒有孤島

第一個想法是拿 topological sort 來改，結果做不出來

## Ver1 - Breadth First Search

建立鄰接表，因為是無向圖，要分別為兩個節點增加鄰接點
建立 visited 陣列
用變數 nodeCount 記錄從 queue 取出的節點數

隨意取一個節點放入 queue

- 從 queue 中取出節點<sub>i</sub>，並將 nodeCount + 1
- 將 visited[i] 改為 1
- 從鄰接表找出所有與節點<sub>i</sub> 相鄰的節點<sub>j</sub>
- 如果 visited[j] 已是 1，代表有 cycle，回傳 false
- 如果 visited[j] 仍是 0
  - 去掉鄰接表中節點<sub>j</sub> 到 節點<sub>i</sub>，避免再走回去
  - 將節點<sub>j</sub> 放入 queue

重覆上述過程直到將 queue 清空

如果 nodeCount = n，就可認定是 tree，回傳 true，反之代表有孤島，回傳 false。

### 複雜度
- n 個節點
- m 個有向邊的數量

#### Time: O(n + m)
- 建立鄰接表: O(m)
- 每個節點最多放入 queue 一次: O(n)

相加後取最大: O(n + m)

#### Space: O(n + m)
- 建立鄰接表: O(m)
- 建立 visit 陣列，容量為 n: O(n)

相加後取最大: O(n + m)

---

## Ver2 - Depth First Search

用遞迴的方式不用從鄰接表刪除記錄，不過要傳入當前的節點到下一層，避免走回路

建立鄰接表，因為是無向圖，要分別為兩個節點增加鄰接點
建立 visited 陣列

挑選任一節點做遞迴
- 如果 visited[當前節點] 已是 1
  - 代表有循環，回傳 false 給上一層遞迴
- 如果 visited[當前節點] 仍是 0
  - 將 visited[當前節點] 設為 1
  - 從鄰接表找出所有與當前節點相鄰的節點<sub>j</sub>，輪詢這些節點<sub>j</sub>
    - 如果 節點<sub>j</sub> 等於 前個節點，跳過，避免走回頭路
    - 呼叫下一層遞迴，如果得到 false，也回傳 false 給上一層遞迴
- 回傳 true 給上一層遞迴

如果遞迴結果是 false，代表有孤島，回傳 false。

檢查陣列 visited 是否都是 1，代表可以探訪所有節點，回傳 true，反之代表有孤島，回傳 false。

### 複雜度
- n 個節點
- m 個有向邊的數量

#### Time: O(n + m)
- 建立鄰接表: O(m)
- 最多可能遞迴到 n 層: O(n)

相加後取最大: O(n + m)

#### Space: O(n + m)
- 要建立鄰接表: O(m)
- 最多遞迴 n 層: O(n)

相加後取最大: O(n + m)