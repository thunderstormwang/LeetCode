# Solution0876 Middle of the Linked List

## 暴力法

跑完所有節點，求得節點總數，再找中點

### 複雜度

#### Time: O(n)
- 要遍歷 1.5 * n 個節點: O(n)

#### Space: O(1)

---

## Ver1 - Iterative

用雙指針，fast 一次走兩個節點，slow 一次走一個節點  
當 fast 遍歷完所有節點，slow 會指向中間的節點

### 複雜度

#### Time: O(n)
- 要遍歷 n 個節點: O(n)

#### Space: O(1)

---

## Ver2 - Recursive

同 Ver1，遞迴版

### 複雜度

#### Time: O(n)
- 要遍歷 n 個節點: O(n)

#### Space: O(1)