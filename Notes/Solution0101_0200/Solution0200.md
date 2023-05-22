# Solution0200

## Depth First Seach

走法跟走 tree 很像，走到 '1' 且沒走過，代表可以進行探索  
用遞迴的方式達成 depth first search，同時要記錄哪些點已走過，不然就進入無窮迴圈了  
也要注意不要超過邊界

### 複雜度

#### Time: O(m * n)
- m * n 個節點都要走過

#### Memory: O(m * n)
- 最多遞迴到 m * n 層

---

## Breadth First Seach

走法跟走 tree 很像，走到 '1' 且沒走過，代表可以進行探索  
用 queue 去達成 breadth first search，同時要記錄哪些點已走過，不然就進入無窮迴圈了  
也要注意不要超過邊界

### 複雜度

#### Time: O(m * n)
- m * n 個節點都要走過

#### Memory: O(m * n)
- quque 最多可能存 n 個節點
