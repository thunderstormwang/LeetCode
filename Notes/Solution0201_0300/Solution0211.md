# Solution0211 Design Add and Search Words Data Structure

## Ver1 - Breadth First Search

跟 [Solution0208](./Solution0208.md) 一樣建立建立 TrieNode 結構。

要變的是 SearchWord 的寫法，
我第一個想到的方法是，因為要支援 '.'，所以跑迴圈將可能的節點都放在 list 裡，最後檢查 list 是否有符合的節點。  
事後查了解答才意識到這是 BFS 的概念，既然可以用 BFS，那也可以用 DFS 去解這題。

### 複雜度
- 字串平均長度: n

#### Time: O(n) -- ?
- AddWord 為 O(n)
- Search 為 O(26<sup>n</sup>)

#### Space: O() -- ?
- 每個節點可能 26 個子節點都有，但不知道何何計算

---

## Ver2 - Depth First Search

同 Ver1，改用 DFS 的方式去解。  
因為這題只要找到一個解可以，用 DFS 會較合適。  

### 複雜度
- 字串平均長度: n

#### Time: O(n) -- ?
- AddWord 為 O(n)
- Search 為 O(26<sup>n</sup>)

#### Space: O(n) -- ?
- 每個節點可能 26 個子節點都有，但不知道何何計算
- 最多遞迴 n 層: O(n)