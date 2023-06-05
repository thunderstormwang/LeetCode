# Solution0127

看完題目，第一個想法是要建立鄰接表，計算所有輸入的字串算出兩兩之間的字元差異  
再找出從 beginWord 到 endWord 的路，且每次移動只能走差異為 1 的路徑  
覺得很麻煩，直接放棄，看了解答才知道其實不需要建立鄰接表  

## Ver1 - BFS

這題要用 BFS 去解，選定一個 index，從 'a'~'z' 都試著將它替換，如果替換後的字存於輸入的字串中，就可以再開始下一輪的探索  

DFS 不適合用這題是因為，一路走到底的路徑不一定就是最短路徑

建立 set wordSet，將所有輸入的字串放入 wordSet

將 beginWord 放入 queue

再從 queue 取出所有元素，令它叫 words  
輪詢 words，令 word[cnt] 為目前輪詢到的字串，從 word[cnt] 每個位置，嘗試用 'a'~'z' 去取代成為 newWord  
如果 newWord 存在於 wordSet，就放入 queue，並將 newWord 從 wordSet 中移除，避免進入無窮迴圈  
輪詢完 words，就結束一輪，深度加 1  

重覆上述過程，直到找到 endWord，那就回傳深度加 1，或是 queue 沒元素，就代表無法從 beginWord 變到 endWord，回傳 0

### 複雜度
- wordList 長度: n
- wrodList 中每個字串的長度: l

#### Time: O(n * l * 26)
- 建立 wordSet: O(n * l) 
- 每個字串最多被放入 queue 一次，被放入 queue 的字串，在每個 index 會被用 26 個字母做替換: O(n * l * 26)

#### Space: O(n)
- wordSet 最多放入 n: O(n)
- queue 最多放入 n: O(n)

---

## Ver1 - BFS

#### Time: O()

#### Space: O()