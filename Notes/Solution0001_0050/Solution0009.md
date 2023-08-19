# Solution0009 Palindrome Number

## Ver1 - 轉成字串

轉成字串，用雙指針 left, right 去比較字元是否相同。

### 複雜度
- x 有幾位數: n

#### Time: O(n)

#### Space: O(n)
- 轉成字串後的長度: O(n)

---

## Ver2 - 轉成倒數

轉成倒數，如果超過 int 最大值也關係，因為最後比較時就知道不是回文了。

### 複雜度
- x 有幾位數: n

#### Time: O(n)

#### Space: O(1)

---

## Ver3 - 轉成倒數

一個比較巧妙的解法，同 Ver2 一樣，但是轉一半，就可以舊數和新數了。  
此法有較多的 edge case 需要處理，我每次寫每次錯...。

### 複雜度
- x 有幾位數: n

#### Time: O(n)

#### Space: O(1)