# Solution0206 Reverse Linked List

## Ver1 - Iterative

只須四步驟

建立 temp 節點，指向 head.next  
將 head.next 指向 newHead  
將 newHead 指向 head  
將 head 指向 temp 節點

### 複雜度

#### Time: O(n)
- 需要遍歷 n 個節點: O(n)

#### Space: O(1)

---

## Ver2 - Recursive

同 Ver1，遞迴版

### 複雜度

#### Time: O(n)
- 需要遍歷 n 個節點: O(n)

#### Space: O(n)
- 最多遞迴 n 層: O(n)

---

## Ver3 - Two Pointer

再次回來寫後想到方法，沒有 Ver1 簡潔，應該記得轉 list 只要多一個變數和四個步驟即可

### 複雜度

#### Time: O(n)
- 需要遍歷 n 個節點: O(n)

#### Space: O(1)