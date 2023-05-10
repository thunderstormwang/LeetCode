# Solution0074

二分法的變型，主要還是找出怎麼切半的方法

## Ver1 先找 Row 再找 Column

我直覺想到這樣，但不是很好寫  
主要是找 Row 時，得用 Binary Search 的變型，因為不一定會找到相符的 target

如果 matrix[middle][0] <= target，令 left = middle  
反之，令 right = middle - 1
如果迴圈終止條件仍用 left <= middle 那麼可能會進入無窮迴圈，將終止條件改為 right - left > 1  
剩兩個元素時，如果 matrix[right][0] <= target，就使用 right 那條 row 往下找，否則就用 left 那條 row  
 
而找 Column 就是標準的 Binary Search

### 複雜度

#### Time: O(log(n))

#### Space: O(1)

---

## Ver2 一維陣列

這想法比較好，我一開沒想到..

把二維陣列當做一維陣列  
初始 left = 0  
初始 right = n * m - 1  

計算出 middle 後
row = middle / matrix[0].Length  
column = middle % matrix[0].Length  
就可以轉換為二維座標

### 複雜度

#### Time: O(log(n))

#### Space: O(1)