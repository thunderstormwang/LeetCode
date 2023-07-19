# Solution0815 Bus Routes

## Breadth First Search

因為要求搭公車的最少次數，要用 BFS

首先維護每個站點的公車路線 busStopRoute，將 [[1,2,7],[3,6,7]] 轉成
- busStopRoute[1] = [0]
- busStopRoute[2] = [0]
- busStopRoute[7] = [0, 1]
- busStopRoute[3] = [1]
- busStopRoute[6] = [1]

初始將 source 放入 queue  
輪詢 queue 的元素，取出 busStop<sub>i</sub>  
從 busStopRoute 取出 busStop<sub>i</sub> 能到達的公車路線，並排除已拜訪過的公車路線'，將公車路線的其它站點也放入 queue  

每次清空 queue，cnt 次數就加 1，如果到達 target，回傳 cnt。如果 queue 已清空卻還未取出 target，代表到達不了，回傳 -1

### 複雜度
- 公車路線數量: n
- 公車路線上的公車站平均數量: m

#### Time: O(n * m)
- 建立 busStopRoute: O(n * m)
- 最差情況下，每個公車路線上的每個公車站都被放入 queue: O(n * m)

相加後取最大: O(n * m)

#### Memory: O(n * m)
- 建立 busStopRoute: O(n * m)
- 建立 visited 陣列: O(n)
- 最差情況下，每個公車路線上的每個公車站都被放入 queue: O(n * m)

相加後取最大: O(n * m)