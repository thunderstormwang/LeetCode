# Solution0377 Combination Sum IV

## Dyuamic Programming

寫出來後，會覺得很像動態規劃中的完全背包的一維陣列，例如 跟 [Solution0518](../Solution0501_0700/Solution0518.md)，就只差在迴圈的順序

我自己認為這題應該與完全背包沒關係，只是很像而已，而且二維陣列的解法也寫不出來。

### 找出 dp 和下標的的意義

令 dp(n) 為從 nums 取出元素組合出和為 n 的組合數，換算成陣列，找 dp[n-1]

### 找出 dp 的狀態推導

假設 nums = [1, 2, 3]，
可以拆出 x + 1，也就是 dp[i] += dp[i-1]  
可以拆出 x + 2，也就是 dp[i] += dp[i-2]  
可以拆出 x + 3，也就是 dp[i] += dp[i-3]  

也就是 dp[i] = Sum(dp[i - nums[j]])，其中 j 為 nums 的下標

### 找出 dp 初始值

因為以 nums[i] = 1 為例，dp[1] += dp[0]，為該要為 1，所以為了計方便，令 dp[0] 為 1 

改求 dp[n]

### 複雜度
- nums 的長度為 n
- target 為 m

#### Time: O(n*m)
- 遍歷 dp，並在每個 dp[i] 做n 次計算: O(n*m)

#### Space: O(m)
- dp 的長度為 m: O(m)