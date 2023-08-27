# Solution0417 Pacific Atlantic Water Flow

## 暴力法

從每個點去做 BFS/DFS ，看看走到最後能否到 Pacific 和 Atlantic，這肯定 TLE...。

可以發現暴加法有重覆計算的地方，改從邊界用 BFS 或 DFS 方式倒著走，並分別用兩個二維陣列 pacific 和 atlantic 去記錄能到達的地方。  
最後取 pacific 和 atlantic 都能到達的點，即為答案

---

## Breadth First Search

### 複雜度
- heights.Length: m
- heights[0].Length: n

#### Time: O(m * n)
- 每個座標最多被放入 pacificQueue 一次: O(m * n)
- 每個座標最多被放入 atlanticQueue 一次: O(m * n)
- 從二維陣列中 pacific 和 atlantic 都可到的地點: O(m * n)

相加後取最大項: O(m * n)

#### Space: O(m * n)
- 二維陣列 pacific : O(m * n)
- 二維陣列 atlantic : O(m * n)
- pacificQueue 最多被放入 m * n:  O(m * n)
- atlanticQueue 最多被放入 m * n:  O(m * n)

相加後取最大項: O(m * n)

---

## Depth First Search
- heights.Length: m
- heights[0].Length: n

### 複雜度

#### Time: O(m * n)
- 最多遞迴 m * n 層: O(m * n)
- 從二維陣列中 pacific 和 atlantic 都可到的地點: O(m * n)

相加後取最大項: O(m * n)

#### Space: O(m * n)
- 最多遞迴 m * n 層: O(m * n)
- 二維陣列 pacific : O(m * n)
- 二維陣列 atlantic : O(m * n)

相加後取最大項: O(m * n)