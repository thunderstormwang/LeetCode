# Solution0221 Maximal Square

## 暴力法

將每個 nums[i][j] 都當作正方形旳左上角，計算所能形成的最大正方形面積。  
計算過程式中最大的正式形即是答案

會 TLE

### 複雜度
- matrix 的長度為 m
- matrix[0] 的長度為 n

#### Time: O(n<sup>2</sup>)
- 遍歷 matrix 的每個元素，在每個元素做 min(m, n) 的擴張計算: O((m*n)<sup>Min(m, n)</sup>)

#### Space: O(1)

---

## Dynamic Programming

暴力法很好想，動態規劃則想不到  
動態規劃的想法如果錯了，就推導不出來了

### 找出 dp 和下標的的意義

令 dp[i][j] 為以 matrix[i][j] 為右下角的正方形的最大邊長

計算過程中最大的 dp[i][j] 即是答案

### 找出 dp 的狀態推導

dp[i][j] = Min(dp[i-1][j-1], dp[i-1][j], dp[i][j-1]) + 1

這推導初次看覺得神奇，但畫個圖就會理解為何這樣推導  
只有當左上、上、左三個點都是 1 時，dp[i][j] 才能形成 2X2 正方形，  
只有當左上、上、左三個點都是 2 時，dp[i][j] 才能形成 3X3 正方形，

推導過程要注意 i, j 不能超過邊界

### 找出 dp 初始值

若 matrix[i][j] 為 '1'，則 dp[i][j] = 1  
若 matrix[i][j] 為 '0'，則 dp[i][j] = 0  

### 複雜度
- matrix 的長度為 m
- matrix[0] 的長度為 n

#### Time: O(m*n)

#### Space: O(m*n)