# Solution0136 Single Number

## 暴力法

將 nums 排序後，兩兩比較。  
會 TLE

### 複雜度

#### Time: O(n * log(n))
- 排序 nums: O(n * log(n))
- 對 nums 所有元素做兩兩比較: O(n)

#### Space: O(1)

---

## Ver1 - Bit Manipulation

逐一對 nums 所有元素做 XOR 運算，最後的結果就是答案

### 複雜度

#### Time: O(n)
- 遍歷 nums: O(n)

#### Space: O(1)