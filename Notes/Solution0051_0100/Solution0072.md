# Solution0072

## 動態規劃 - 2維陣列

todo 以下未改

[Solution0392](Solution0392.md) 的進階版  

### 找出 dp 和下標的的意義

在長度為 n 的 word1 與長度為 m 的 wrod2 所需要新增剛除修改的元素的最小數目 = dp(n,m)，換算成陣列求 dp[n-1][m-1]

### 找出 dp 的狀態推導

dp[i][j] 的來源有以下
- text1[i] = text[j]，那就等於長度為 i-1 的 word1 和 長度為 j-1 的 word2 的最小數目，也就是 dp[i-1][j-1]
- 反之，就從以下取最小
  - 從長度為 i-1 的 word1 和 長度為 j 的 wrod2 的最小數目加 1，也就是刪除 word1 的一個元素，也就是 dp[i-1][j] + 1
  - 從長度為 i 的 word1 和 長度為 j-1 的 word2 的最小數目加 1，刪除 word2 的一個元素就等於在 word1 新增一個元素，也就是 dp[i][j-1] + 1
  - 從長度為 i-1 的 word1 和 長度為 j-1 的 word2 的最小數目加 1，也就是替換 word1 的一個元素，也就是 dp[i][j-1] + 1

### 找出 dp 初始值

因為計算來源有 dp[i-1][j-1]，須把 dp[0][j] 另外計算，發現要想一些判斷，dp[i][0] 也是一樣的情況

讓陣列的數目各加 1，可免去這些麻煩，換成求 dp[n][m]

dp[i][0] = i，0 <= i <= n  
dp[0][j] = j，0 <= j <= m

### 複雜度

#### Time: O(n*m)

#### Space: O(n*m)

---

## 動態規劃 - 1維陣列

dp[i][j] 的來源有以下
- dp[i-1][j-1]
- Min(dp[i-1][j-1], dp[i-1][j], dp[i][j-1]) + 1

若簡化成一維陣列，dp[i-1][j-1]、dp[i][j-1] 都會變成 dp[j-1]，差別是 dp[i-1][j-1] 是舊值，經過計算會被蓋掉變成 dp[i][j-1] 成為新值

需要把 dp[i-1][j-1] 先存起來再作計算

```csharp
temp = dp[j]
if (text1[i] == text2[j])
{
    dp[j] = pre + 1
}
else
{
    dp[j] = Math.Max(dp[j-1], dp[j])
}
pre = temp;
j++;
```

### 複雜度

#### Time: O(n*m)

#### Space: O(m)