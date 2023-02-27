# Solution0053

## 暴力法:
長度 n 的子陣列有 1 個  
長度 n-1 的子陣列有 2 個  
...  
長度 1 的子陣列有 n 個

總共有 1 + 2 + ... + n 個組合

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Memory: O(n) -- 最多遞迴 n 層

---

## 動態規劃:
想求得 dp(i): 0 ~ i 的最大子陣列和, 可以先計算 dp(i-1) 再從以下取最大
- 從 dp(i-1) + num[i]
- num[i]

這意思是說如果 dp(i-1) + num[i] 如果小於 num[i]，那就直接從 num[i] 開始算子陣列

### 找出 dp 和下標的的意義

在 nums<sub>0</sub>, ...,  nums<sub>n-1</sub> 中以 nums<sub>n-1</sub> 為結尾的最大子陣列和 = dp(n)，換算成陣列，求 dp[n-1]

### 找出 dp 的狀態推導

dp[i] 的來源有以下
- 將 nums[i] 加入子陣列和，dp[i-1] + nums[i]
- 以 nums[i] 作為開頭，nums[i]

兩者取最大

### 找出 dp 初始值

dp[0] = nums[0]

### 複雜度

#### Time: O(n)

#### Memory: O(n()

---

## 貪心解法

把 dp 用一個變數給取代掉  
curr: 包含當前元素的最大子陣列和  
result: 到目前為止的最大子陣列和

### 複雜度

#### Time: O(n)

#### Memory: O(1)