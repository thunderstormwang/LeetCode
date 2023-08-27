# Solution1730 Shortest Path to Get Food

難得 graph 中有一看就會的題目

## Breadth First Search

因為要求找最短路徑的值，用 BFS  
找到起始點，放入 queue

從 queue 取出元素  
如果四週有還未起出邊界且還沒探訪過的 cell
- 如果該 cell 是食物，回傳深度加 1
- 如果該 cell 是空格，將該 cell 標記為已探訪過，並放入 queue
清空完一層的 queue，深度加 1

重覆上述步驟直到 queue 為空

### 複雜度
- grid.length: m
- grid[0].length: n

#### Time: O(m * n)
- 尋找起始點: O(m * n)
- 每個 cell 最多放入 queue 一次 m * n: O(m * n)

#### Space: O(m * n)
- queue 最多放 m * n: O(m * n)