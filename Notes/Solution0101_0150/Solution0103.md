# Solution0103 Binary Tree Zigzag Level Order Traversal

## Ver1 最後再做反轉

跟 [Solution0102](Solution0102.md) 一樣的做法  
然後在 depth % 2 == 1 的層數做反轉

也就是要花額外時間做反轉

### 複雜度

#### Time: O(n)
- 要遍歷每個節點: O(n)
- 做反轉的層的節點數最多為 n: O(n)

#### Space: O(n)
- queue 最多放 n 個節點: O(n)

--- 

## Ver2 改遍歷順序

用 stack 去做 BFS，如此每層就會自動反過來，  
但還需要一個變數去判斷每層的節點該從 由左至右 或 由右至左 放子節點進 stack

跟 Ver1 的做法相比，不用花額外時間做反轉，但需要額外空間

### 複雜度

#### Time: O(n)
- 要遍歷每個節點: O(n)

#### Space: O(n)
- queue 最多放 n 個節點: O(n)
- 做反轉的層的節點數最多為 n: O(n)

---

## Ver3 Breadth First Search 調整放入的位置

### 複雜度

#### Time: O(n)
- 要遍歷每個節點: O(n)

#### Space: O(n)
- queue 最多放 n 個節點: O(n)

---

## Ver4 Depth First Search 調整放入的位置

### 複雜度

#### Time: O(n)
- 要遍歷每個節點: O(n)

#### Space: O(n)
- 最多遞迴 n 層: O(n)