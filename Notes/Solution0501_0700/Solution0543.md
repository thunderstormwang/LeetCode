# Solution0543

## Ver1

採用 Breadth First  
先輪詢一遍 mat，將所有為 0 的 [i, j] 存進 queue  
只要 queue 中仍有元素，且 mat[i][j] 的四個方向仍可計算較小的 distance，就增加至 queue，途中要注意不要超過邊界  

### 複雜度

#### Time: O(m * n)

#### Space: O(m * n)

---

## Ver2

輪詢 mat 三次  
第一次將不為 0 的 mat[i][j] 都更新為 int.MaxValue - 1  
第二次從左上開始，更新每個 mat[i][j] 的右方和下方的元素
- mat[i+1][j] = Math.Min(mat[i][j] + 1, mat[i+1][j])
- mat[i][j+1] = Math.Min(mat[i][j] + 1, mat[i][j+1])

第二次從右下開始，更新每個 mat[i][j] 的左方和上方的元素
- mat[i-1][j] = Math.Min(mat[i][j] + 1, mat[i-1][j])
- mat[i][j-1] = Math.Min(mat[i][j] + 1, mat[i][j-1])

### 複雜度

#### Time: O(m * n)

#### Space: O(1)