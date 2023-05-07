# Solution0037

考驗寫程式的功力  
要用遞迴，在 board[i][j] 設定新數字後，要檢查 row, column, 9 宮格是否符合要求，不符合就換一個數字，符合就用新的 [i][j+1]，若是 j+1 已到 9，就換成 [i+1][0]，然後進入下一層遞迴

檢查 row, column 很簡單  
檢查 9宮格的數字就要好好想想了

這次原本比照 [Solution0037](Solution0037.md) 的做法，不過看到解答區中有更簡便的做法
```csharp
var blockTopLeftRow = row / 3 * 3;
var blockTopLeftColumn = column / 3 * 3;
```
那麼 9 宮格就跑 
- i: blockTopLeftRow ~ blockTopLeftRow + 3 
- j: blockTopLeftColumn ~ blockTopLeftColumn + 3


## Ver1

以前做的，在 board[i][j] 設定一個數字後，檢查
- 整條 row 是否有重覆數字
- 整條 column 是否有重覆數字
- 9 宮格內是否有重覆數字

這做法可行，但是超時，後來改用 set 儲存 row, column, 9 宮格中已用上的數字，才勉強過關

### 複雜度

#### Time: O(9<sup>n</sup>)
- n 為 「.」的個數，每個「.」有 9 個選擇

#### Space: O(n)
- n 為 「.」的個數

---

## Ver2

跟 Ver1 差在檢查的做法不一樣，看解答的做法才知道是自己在 Ver1 的做法是想太多..  
board[i][j]，決定一個 candidate
- 整條 row 是否有跟 candidate 重覆的數字
- 整條 column 是否有跟 candidate 重覆的數字
- 9 宮格內是否有跟 candidate 重覆的數字

這做法就快很多，也比較接近人去解數獨的行為

### 複雜度

#### Time: O(9<sup>n</sup>)
- n 為 「.」的個數，每個「.」有 9 個選擇

#### Space: O(n)
- n 為 「.」的個數