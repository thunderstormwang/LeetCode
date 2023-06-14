# Solution0210

## 暴力法

如果按照 [Solution0079](../Solution0051_0100/Solution0079.md) 作法，  
在外層多加迴圈，會 TLE

### 複雜度
- board.Length: n
- board[0].Length: m
- 每個單詞平均長度為 l

#### Time: O(n * m * 4 <sup>l</sup>)
- 最壞情況下，每個位置都要往四個方向做探索，直到字母不匹配或長度超過正在匹配的字串: O(n * m * 4 <sup>l</sup>)

#### Space: O(l)
- 最多遞迴 l 層: O(l)

---

## 字典樹 Trie

完全不會，直接問 chatgpt

要建立字典樹，當走到不可能的路徑時，立即回頭，減少無謂的計算

### 複雜度
- k 個單詞數量
- 每個單詞平均長度為 l

#### Time: O(k * l + l<sup>4</sup>)
- 建立字典樹: O(k * l)
- 最壞情況下，在每個字母要往四個方向做探索: O(l<sup>4</sup>)

#### Space: O(k * l)
- 建立字典樹: O(k * l)