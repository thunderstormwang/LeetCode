# Solution0150 Evaluate Reverse Polish Notation

## Ver1

因為被歸類在 stack，就省去從範例弄懂題目的時間

遍歷 tokens
- tokens[i] 不為運算符號，將 tokens[i] 放入 stack
- tokens[i] 為運算符號
  - nums2 = stack.Pop()
  - nums1 = stack.Pop()
  - 運算完再放入 stack

stack 頂部元素(也是剩餘唯一的元素)即是答案

### 複雜度

#### Time: O(n)
- 需要遍歷 tokens 所有元素: O(n)

#### Memory: O(n)
- stack 最多要儲存 tokens 所有元素: O(n)