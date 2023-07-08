# Solution0141 Linked List Cycle

## Ver1 - HashSet

用 hashSet 記錄已走過的節點

### 複雜度
- 節點數目: n

#### Time: O(n)
- 最多要遍歷 n 個節點: O(n)

#### Space: O(n)
- hashSet 最多要儲存 n 個節點: O(n)

---

## Ver2 - Two Pointer

很像跑操場，操場的跑道是環狀，兩個人的跑步速度，一快一慢，最終會碰面  
所以可用快慢指針，快指針一次走兩個節點，慢指針一次走一個節點，如果有 cycle 的話，快慢指針最終會指到同一個節點  
或是快指針遍歷到節點為 null，代表沒有 cycle

### 複雜度

#### Time: O(n)
- 最多要遍歷 n 個節點: O(n)

#### Space: O(1)

---

## Ver3 - Two Pointer

同 Ver2，但是從 dummyNode 開始遍歷

### 複雜度

#### Time: O(n)
- 最多要遍歷 n 個節點: O(n)

#### Space: O(1)