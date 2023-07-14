# Solution0234 Palindrome Linked List

## Ver1

遍歷所有節點，將節點複製到另一個 list  
使用雙指針，個別從頭尾往內去比較元素

### 複雜度

#### Time: O(n)
- 需要遍歷所有節點: O(n)

#### Space: O(n)
- list 最多放 n 個節點: O(n)

---

## Ver2

大方向很容易想
- 拆半
- 反轉後半段
- 比較兩個 list

拆半可利用快慢指針  
然後反轉後半段  
最後比較兩個 list  
  
### 複雜度

#### Time: O()

#### Space: O()