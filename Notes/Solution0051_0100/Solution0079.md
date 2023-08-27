# Solution0079 Word Search

難得做到一看就會的題目

## Depth First Search

DepthFirstSearch，且需要一個 int[][] visited 記錄走過的位置，避免進入無窮迴圈

### 複雜度
- board 的 row 的數量: m
- board 的 column 的數量: n
- word 長度: l

#### Time: O(m * n * 4<sup>l</sup>)
- 最差情況下，board 每個位置都要輪詢做為起始位置，且每次遞迴有 4 個方向可選擇: O(m * n * 4<sup>l</sup>)

#### Space: O(m * n + l)
- visited 的空間: O(m * n)
- 最多遞迴 l 層: O(l)