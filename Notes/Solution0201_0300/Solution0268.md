# Solution0268 Missing Number

## Ver1 - Math

計算應有的總和 n * (n + 1) / 2，  
再減去實際的總和，就是缺少的數字

### 複雜度

#### Time: O(n)
- 遍歷 nums 計算實際總和: O(n)

#### Space: O(1)

---

## Ver2 - Bit Manipulation

由於陣列中的數字都是 0 ~ n，但少一個數字，  
可以將 0 ~ n 這些數字做 XOR，再將陣列中的數字做 XOR，  
運算結果即是答案

### 複雜度

#### Time: O(n)
- 遍歷 nums: O(n)

#### Space: O(1)