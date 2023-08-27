# Solution0074 Search a 2D Matrix

二分法的變型，主要還是找出怎麼切半的方法

## Ver1 先找 Row 再找 Column

我直覺想到這種寫法，但不是很好寫  

在是找 Row 時，可參考 [Solution0981](../Solution0501_9999/Solution0981.md) 的做法，讓 left 指向指向第一個大於等於 target 的 index，然後回傳 left - 1，如果 left 算出來是 0，代表矩陣內所有元素都比 target 大，可以回傳 false

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