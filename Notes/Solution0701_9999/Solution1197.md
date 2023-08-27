# Solution1197 Minimum Knight Moves

## Breadth First Search

因為是求最小步數，所以得用 BFS  
不過我卡在怎麼縮小範圍上...，騎士有 8 種走法  
第一步有 8 種  
第二步有 64 種  
第三步有 512 種  
第四步有 4096 種  
第五步有 32768 種  
...
每次都將 8 種走法放入 queue，肯定會 TLE

因為是從 [0, 0] 開始走，那麼求走到 [x, y] 的最小步數就跟求走到 [Math.Abs(x), Math.Abs(y)] 的最小步數是一樣的，那麼就跟範圍縮到第一象限了，也就是如果讓騎士走到座標 [i, j] 且 i < 0 或 j < 0> 的座標肯定不會得到最小步數，因為還要多花幾步跳回來  
而如果 i - x > 2 或 j - y > 2 的座標肯定不會得到最小步數，因為還要多花幾步跳回來  

將 [0,0] 放入 queue

如果 queue 中還有元素
- 輪詢這層 queue 中所有元素
- 取出 queue 的元素，座標<sub>i</sub>
  - 如果座標<sub>i</sub> 即為 [x, y]﹐回傳 step 
  - 反之
    - 輪詢座標<sub>i</sub> 的八種走法 座標<sub>j</sub>
      - 如果 座標<sub>j</sub> 小於 0 或是橫座標大於 x + 2 或縱座標大於 y + 2 或是已被拜訪過，跳過
      - 反之
        - 將座標<sub>j</sub> 放入 queue
        - 記錄座標<sub>j</sub> 已被拜訪過
- step++

### 複雜度
- 橫座標x : n
- 縱座標y : m

#### Time: O(n * m)
- 每個節點最多被放入 queue 一次: O(n * m)

#### Time: O(n * m)
- queue 最多放 n * m 個位置: O(n * m)