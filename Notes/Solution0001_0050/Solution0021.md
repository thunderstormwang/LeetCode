# Solution0021 Merge Two Sorted Lists

## Ver1

比較 list1 與 list2 的當前節點，決定哪個節點可以被加入 merge list  
當走完其中一個 list 後，要將另一個 list 的節點都加入 merge list

### 複雜度
- list1 有 n 個節點
- list2 有 m 個節點

#### Time: O(n+m)

#### Space: O(1)

---

## Ver2

因為覺得重覆的程式碼很多，就想辦法合併，也變得不好懂了

### 複雜度
- list1 有 n 個節點
- list2 有 m 個節點

#### Time: O(n+m)

#### Space: O(1)