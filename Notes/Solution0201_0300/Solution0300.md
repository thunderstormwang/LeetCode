# Solution0300

## 動態規劃

### 找出 dp 和下標的的意義

在 num<sub>0</sub>, ..., num<sub>n-1</sub> 中，以 num<sub>n-1</sub> 作結尾的子序列長度

### 找出 dp 的狀態推導

dp[i] 的來源為 dp[j] + 1 取最大，0 <= j < i

### 找出 dp 初始值

dp[i] = 1，0 <= i < n

最後找出最大的 dp[i] 即為答案

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(n)