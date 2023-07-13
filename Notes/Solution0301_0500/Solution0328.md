# Solution0328 Odd Even Linked List

## Ver1 

我用跟 [Solution0143](../Solution0101_0150/Solution0143.md) 很像的解法  
拆成兩個 list，再組合

遇到要求只能使用原本 list 的題目，如果想要一次過，要考慮將 list 拆掉後，個別 list 的最後一個節點是否有指向 null

#### Time: O(n)
- 需要遍歷所有節點: O(n)

#### Space: O(1)