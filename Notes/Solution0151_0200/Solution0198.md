# Solution0198

## Ver1 - Dynamic Programming

### 找出 dp 和下標的的意義

令 dp(n) 為搶劫 nums<sub>0</sub>, ..., nums<sub>n-1</sub> 共 n 個房子的最大金額

換算成陣列，找 dp[n-1]

### 找出 dp 的狀態推導

dp[i] 的來源有以下:
- 不搶 nums[i]，搶前面 i-1 個房子的最大金額，dp[i-1]
- 搶 nums[i]，搶前面 i-2 個房子的最大金額 加上 nums[i]，dp[i-2] + nums[i]

以上取最大

### 找出 dp 初始值

nums 的長度可能為 1  
令 dp[0] = 0，一間房子都沒有，最大金額自然是 0  
令 dp[1] = nums[0]，只有一間房子，自然是要搶

所以改成求 dp[n]

### 複雜度

#### Time: O(n)

#### Space: O(n)

---

## Ver2 - Dynamic Programming

如果將 dp 的長度設為 n，會有較多 edge case 要處理

### 複雜度

#### Time: O(n)
- 遍歷陣列 nums: O(n)

#### Space: O(n)
- dp 的長度: O(n)

---

也可以用兩個變數來記錄 dp[i-1] 和 dp[i-2]，這樣就不用額外的空間了  
也可以用遞迴做