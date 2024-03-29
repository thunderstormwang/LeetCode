# Solution0062

## Ver1 - Dynamic Programming

### 定義 dp
到 m, n 的所有不同路徑 = dp(m,n)  

### 定義 dp 的狀態推導
每個格子可以從其上方或左方來，dp[i][j] = dp[i-1][j] + dp[i][j-1]
  
### 定義 dp 初始值
- dp[i][0] 是 1，0 <= i < m
- dp[0][j]是 1，0 <= j < n
  
### 複雜度

#### Time: O(n*m)

#### Space: O(n*m)

---

## Ver2 - Math

一共有 (m-1) + (n-1) = m + n -2 步要走，其中 (m-1) 步要往下走，  
相當於在 m + n -2 個空格中挑出 m-1 個空格往下走

也就是計算 C<sup>m + n -2</sup><sub>m - 1</sub>

套公式解需要注意是否有溢位的問題

### 複雜度

#### Time: O(Min(n, m))

#### Space: O(1)