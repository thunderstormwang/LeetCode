# Solution0213

有想到是找 cycle，不過看到輸入卻想不到怎麼下手  
原來還是要先轉成鄰接表才好做  
## togological sort

### 複雜度

#### Time: O(n + m)
- n 個節點, m 個有向邊的數量
- 建立鄰接表: O(m)

#### Space: O(n)
- 要建立 visit 陣列，容量為 n: O(n)
- 最多遞迴 n 層: O(n)