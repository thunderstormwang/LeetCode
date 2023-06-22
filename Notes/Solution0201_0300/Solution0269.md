# Solution0269 Alien Dictionary

好難，一看題目就呆住了，完全沒想到是 topological sort 的變形

## Ver1 Breadth First Search

知道是用 topological sort 去解後，那就要建立鄰接表

題目給的  
"wrt",  
"wrf",  
"er",  
"ett",  
"rftt"  

因為題目有說明有照順序排，且如果字元 a 的順序比字元 b 前面，那可以預期範例會 aXX 在 bXX 之前

那就可以建立鄰接表
- t -> f
- w -> e
- r -> t
- e -> r

這裡我卡了很久，因為以 wrt 為例，是不是也該建立
- w -> r
- r -> t

事實上這是多想了  
還有不定每個字母都會出現，鄰接表和 inDegrees 最好用 Dictionary 去儲存，而不是陣列

有了鄰接表，就可以比照 [Solution0210](Solution0210.md) 建立順序

### 複雜度
- words 長度: n
- 每個字串的平均長度: l

#### Time: O(n * l)
- 建立鄰接表: O(n * l)
- 建立 inDegrees: O(n * l)
- 26 個字母每個最多被放入 queue 一次: O(1)

相加後取最大項: O(n * l)

#### Space: O(1)
- 建立鄰接表，最壞情況下，每個字母都與其它字母鄰接，26 * 26: O(1)
- 建立 inDegrees，最多就 26 個字母: O(1)
- 26 個字母最多被入 queue 一次: O(1)

相加後取最大項: O(1)

---

## Ver2 - Depth First Search

有了鄰接表，就可以比照 [Solution0210](Solution0210.md) 建立順序

### 複雜度
- words 長度: n
- 每個字串的平均長度: l

#### Time: O(n * l)
- 建立鄰接表: O(n * l)
- 建立 visited: O(n * l)
- 最多遞迴 26 次: O(1)

相加後取最大項: O(n * l)

#### Space: O(1)
- 建立鄰接表，最壞情況下，每個字母都與其它字母鄰接，26 * 26: O(1)
- 建立 visited，最多 26 個字母: O(1)
- 最多遞迴 26 次: O(1)

相加後取最大項: O(1)