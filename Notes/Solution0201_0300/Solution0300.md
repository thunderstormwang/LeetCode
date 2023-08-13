# Solution0300

## Ver1 - Dynamic Programming

### 找出 dp 和下標的的意義

令 dp(n) 為在 num<sub>0</sub>, ..., num<sub>n-1</sub> 中，以 num<sub>n-1</sub> 作結尾的子序列長度，換算成陣列，找 dp[n-1]

計算過程中，最大的 dp[i] 即為答案

### 找出 dp 的狀態推導

dp[i] 的來源為 Max(dp[j]) + 1，0 <= j < i

### 找出 dp 初始值

dp[i] = 1，0 <= i < n

### 複雜度

#### Time: O(n<sup>2</sup>)
dp[1] 要遍歷 dp[0]  
dp[2] 要遍歷 dp[0] 和 dp[1]  
...  
dp[n-1] 要遍歷 dp[0] ~ dp[n-2]  

加總起來為 n<sup>2</sup>

#### Space: O(n)
- dp 的長度

---

## Ver2 - Binary Search

想不出解法，直接看解答

維護一個 list，裡的元素要由小放到大  
list 初始放入 nums[0]

遍歷 nums[1] ~ nums[n-1]，  
當 nums[i] 比 list 的第一個元素小，則取代 list 的第一個元素  
當 nums[i] 比 list 的最後一個元素大，則加入 list  
否則，用 binary search 找到第一個比 nums[i] 大的元素，並取代它  

這算 binary search 的變形題，要注意 目標元素 > list[middle] 和 目標元素 <= list[middle] 的處理

### 複雜度

#### Time: O(n * log(n))

#### Space: O(n)