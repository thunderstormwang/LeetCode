# Solution0207

有想到是找 cycle，不過看到輸入卻想不到怎麼下手  
原來要先從建立出鄰接表開始做  

## Ver1 - Togological Sort

### 複雜度

#### Time: O(n + m)
- n 個節點, m 個有向邊的數量
- 建立鄰接表: O(m)
- 最多遞迴 n 層: O(n)

相加後取最大: O(n + m)

#### Space: O(n + m)
- 要建立鄰接表: O(m)
- 要建立 visit 陣列，容量為 n: O(n)
- 最多遞迴 n 層: O(n)

相加後取最大: O(n + m)

---

## Ver2 - Depth First Search

跟 Ver1 差別在不使用 Topological Sort，單純使用 Depth First Search，所以有重覆的計算  
如果能回到原點，代表有循環  
如果每個點都不能回到原點，代表可修完所有的課

### 複雜度

#### Time: O(n<sup>2</sup> + m)
- n 個節點, m 個有向邊的數量
- 建立鄰接表: O(m)
- 在每個節點都做 Depth First Search，最多可能遞迴到 n 層: O(n<sup>2</sup>)

相加後取最大: O(n<sup>2</sup> + m)

#### Space: O(n + m)
- 要建立鄰接表: O(m)
- 最多遞迴 n 層: O(n)

相加後取最大: O(n + m)

---

## Ver3 - Breadth First Search

除了要計算鄰接表，也要計算每個節點的前置課程的數量  
然後將沒有前置課程的節點加入 queue，只能從這些節點開始 traverse

從 queue 中取出節點A，將前置課程中含有節點A的前置數量減1，如果產生新的前置課程數量為 0 的節點，就加入 queue  

如果加入 quque 的數量跟所有課程數量相等，就代表沒有循環，可以修完所有課程

### 複雜度

#### Time: O(n + m)
- n 個節點, m 個有向邊的數量
- 建立鄰接表: O(m)
- 初始找前置數量為 0 的節點: O(n)
- 每個節點只會被放入 queue 一次，且跑遴接表不會超過 m: O(n + m)

相加後取最大: O(n + m)

#### Space: O(n + m)
- 要建立鄰接表: O(m)
- 要建立前置數量的陣列: O(n)
- queue 最多放入 n 個節點: O(n)

相加後取最大: O(n + m)