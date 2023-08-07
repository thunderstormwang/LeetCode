# Solution0208 Implement Trie (Prefix Tree)

## Trie

建立 TrieNode 結構，每個 TrieNode 節點包含一個 TrieNode 陣列，長度為 26。若該節點是一個字串的結尾，則以 Word 記錄該字串。

### 複雜度
- 字串平均長度: m

#### Time: O(m) -- ?
- Insert, Search, StartWith 為 O(m)

#### Space: O() -- ?
- 每個節點可能 26 個子節點都有，但不知道何何計算