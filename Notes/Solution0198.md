# Solution0198

### 找出 dp 和下標的的意義

搶劫 nums<sub>0</sub>, ..., nums<sub>n-1</sub> 共 n 個房子的最大金額 dp(n)

換算成陣列，找 dp[n-1]

### 找出 dp 的狀態推導

dp[i] 的來源有以下:
- 不搶 nums[i]，dp[i] = dp[i-1]
- 搶 nums[i]，dp[i] = dp[i-2] + nums<sub>i</sub>

以上取最大

### 找出 dp 初始值

nums 的長度可能為 1

就令 dp[0] = 0，一間房子都沒有，最大金額自然是 0

就令 dp[1] = nums<sub>0</sub>，只有一間房子，自然是要搶

改成求 dp[n]

### 複雜度

#### Time: O(n)

#### Space: O(n)