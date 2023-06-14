# Solution0329

## Ver1 - Depth First Search

在每個節點作 DFS，看能走多遠  
果不其然，會 TLE...

### 複雜度
- matrix.Length: n
- matrix[0].Length: m

#### Time: O((n*m)<sup>2</sup>)
- 輪詢每個節點 且 最多遞迴 n * m 層: O((n*m)<sup>2</sup>)

#### Space: O(m * n)
- 最多遞迴 n * m 層: O((n*m)<sup>2</sup>)

---

## Ver2 - Depth First Search

因為 Ver1，改將每個節點能走最遠的距離記到二維陣列 record  

只有當 record[i][y] 還未計算過，才需要做多遞迴，因此可以改遞迴的終止條件

### 複雜度
- matrix.Length: n
- matrix[0].Length: m

#### Time: O(n * m) --?

#### Space: O(m * n)
- 最多遞迴 n * m 層: O(n * m)
- record 容量: O((n * m)