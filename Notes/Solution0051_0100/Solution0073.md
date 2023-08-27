# Solution0073 Set Matrix Zeroes

## 空間 O(m * n)

用 List 儲存 matrix 中為 0 的座標

### 複雜度

#### Time: O(m * n)

#### Space: O(m * n)

---

## 空間 O(m + n)

建立兩個陣列，長度分度為 m 和 n  
輪詢 matrix 的每個元素，遇到 0 就記錄到兩個陣列裡

### 複雜度

#### Time: O(m * n)

#### Space: O(m + n)

---

## 空間 O(1)

想不到怎麼解..  

輪詢 matrix，遇到 0 就放到第 0 個 row 和 第 0 個 column，  
為此需要兩個變數，儲存第 0 個 row 和第 0 個 column 是否也要為 0，避免原本的值被蓋掉

所以步驟可拆解成
- 輪詢 matrix 的第 0 row，若有 0，則 firstRowZero 為 true
- 輪詢 matrix 的第 0 column，若有 0，則 firstColumnZero 為 true
- 輪詢 matrix 的其它元素，若 matrix[i][j] 為 0，則令 matrix[i][0] 和 matrix[0][j] 都為 0
- 輪詢 matrix 的第 0 column，若 matrix[i][0] 為 0，則將對應的 row 都設為 0
- 輪詢 matrix 的第 0 row，若 matrix[i0[j] 為 0，則將對應的 column 都設為 0 
- 若 firstRowZero 為 true，則第 0 row 都設為 0
- 若 firstColumnZero 為 true，則第 0 column 都設為 0

### 複雜度

#### Time: O(m * n)

#### Space: O(1)