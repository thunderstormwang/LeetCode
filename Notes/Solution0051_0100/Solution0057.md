# Solution0057 Insert Interval

逐一走過 intervals  
- intervals[i][1] < newInterval[0]，沒有交集，將 intervals[i] 加入新陣列
- intervals[i][0] > newInterval[1]，沒有交集，且找到可以塞入 newInterval 的位置，將 newInterval 加入新陣列
- 其它狀況，合併 intervals[i] 和 newInterval
  - newInterval[0] = Min(newInterval[0], intervals[i][0])
  - newInterval[1] = Max(newInterval[1], intervals[i][1])

最後要考慮還未加入新陣列的 intervals，還有一直未加入新陣列的 newInterval

### 複雜度

#### Time: O(n)

#### Space: O(n)