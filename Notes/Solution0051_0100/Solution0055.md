# Solution0055 Jump Game

## Ver1 - Dynamic Programming

### 找出 dp 和下標的的意義

令 dp(n) 為在 num[0], ..., num[n-1] 中，可達到最遠距離，換算成陣列，找 dp[n-1]  

確認 dp[n-1] 是否大於等於 n-1 即可

### 找出 dp 的狀態推導

dp[i]的來源有以下情況：

如果到不了 i，那只能是 dp[i-1]

如果到得了 i，那從以下選最大
- num[0], ..., num[i-1]中，可達到的最遠距離，也就是 dp[i-1]
- nums[i] 可達到的最遠距離，也就是 i + nums[i]

### 找出 dp 初始值

dp[0] = nums[0]

### 複雜度

#### Time: O(n)
- 遍歷 nums: O(n)

#### Space: O(n)
- dp 的長度: O(n)

---

## Ver2 - Dynamic Programming

因為 dp[i] 只跟 dp[i-1] 有關，我們可以用一個變數來記錄 dp[i-1]，而不用一個陣列

### 複雜度

#### Time: O(n)
- 遍歷 nums: O(n)

#### Space: O(1)