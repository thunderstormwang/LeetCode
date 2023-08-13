# Solution0070 Climbing Stairs

其實就是計算費式數列

## Ver1 - Dynamic Programming - Iterative

### 找出 dp 和下標的的意義
令 dp(n) 為爬到 n 階的方式  
為了計算方便，將長度設為 n+1，所以要求 dp[n]

### 找出 dp 的狀態推導

在第 i-1 階只能選擇爬 1 階上到第 i 階。  
在第 i-2 階也只能選擇爬 2 階上到第 i 階，因為若是先爬 1 階上到第 i-1 階，再爬 1 階上到第 i 階，就會有重覆計算的問題。

所以推導公式為: dp[i] = dp[i-2] + dp[i-1]。

### 找出 dp 初始值
dp[1] = 1  
dp[2] = 2  

### 複雜度

#### Time: O(n)

#### Space: O(n)

---

## Ver2 - Dynamic Programming - Recursive

同 Ver1，改用遞迴

### 複雜度

#### Time: O(n)

#### Space: O(n)

---

## Ver3 - Dynamic Programming - Iterative

同 Ver1，但是只用兩個變數來記錄前兩個階層的結果

### 複雜度

#### Time: O(n)

#### Space: O(n)

## Ver4 - Dynamic Programming - 完全背包 1維陣列

查網路，有人將它視作完全背包，以後再來研究他的解題思路吧

### 複雜度

#### Time: O(n)

#### Space: O(n)