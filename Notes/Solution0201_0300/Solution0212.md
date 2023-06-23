# Solution0212 Word Search II

## 暴力法

如果按照 [Solution0079](../Solution0051_0100/Solution0079.md) 作法，  
在外層多加迴圈，會 TLE

### 複雜度
- board.Length: n
- board[0].Length: m
- words.Length: k
- 每個單詞平均長度為 l

#### Time: O(n * m * k * 4 <sup>l</sup>)
- 最壞情況下，每個格子都要往四個方向做探索，直到字母不匹配或長度超過正在匹配的字串: O(n * m * 4 <sup>l</sup>)

#### Space: O(l)
- 最多遞迴 l 層: O(l)

---

## 字典樹 Trie

完全不會，直接問 chatgpt

要建立字典樹，當走到不可能的路徑時，立即回頭，減少無謂的計算

因為已用過的格子不能再使用第二次，用 BFS 會頗麻煩，要用 DFS 去 traverse，將當前格子標記為已用過，再對 4 邊的格子做 DFS，再將當前格標記回未被使用

### 複雜度
- board.Length: n
- board[0].Length: m
- words.Length: k
- 每個單詞平均長度為 l

#### Time: O(k * l + n * m * l<sup>4</sup>)
- 建立字典樹: O(k * l)
- 最壞情況下，在每個格子要往四個方向做探索: O(n * m * l<sup>4</sup>)

#### Space: O(k * l)
- 建立字典樹: O(k * l)