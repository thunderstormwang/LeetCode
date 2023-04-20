# Solution0977

## 暴力法

所有元素做了平方後再作排序

### 複雜度

#### Time: O(n * log(n))
- 輪詢做平方: O(n)
- 排序: O(n * log(n))

相加後取最大項: O(n * log(n))

#### Memory: O(n)

---

## Two Pointer

雙指針，從兩端往內找，也就是從最大的元素開始排起

### 複雜度

#### Time: O(n)

#### Memory: O(n)