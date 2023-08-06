# Solution0053 Maximum Subarray

## 暴力法

長度 n 的子陣列有 1 個  
長度 n-1 的子陣列有 2 個  
...  
長度 1 的子陣列有 n 個

總共有 1 + 2 + ... + n 個組合

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Memory: O(n)
- 最多遞迴 n 層

---

## Ver1 - Dynamic Programming

雖然可以用 dp 解，但需要想清楚 dp 的定義  
如果令 dp(0, n) 為在 nums<sub>0</sub>, ...,  nums<sub>n-1</sub> 中的最大子陣列和作法雖然可行，但會產生重複計算  
例如假設 dp(i, j) 就最大子陣列和，那麼代入所有 x <= i, y >= j 的 dp(x, y) 都會算出跟 dp(i, j) 一樣的結果，  
而且上述作法需要使用二維陣列，而題目有設計出當使用二維陣列會產生 out of memory 的 testcase

所以需要改變想法  
令 dp(i, n) 為在 nums<sub>i</sub>, ...,  nums<sub>n-1</sub> 中以 nums<sub>n-1</sub> 為結尾的最大子陣列和  
然後會發現 i 會固定為 0，所以可以簡化為 dp(n)  
也就可以使用一維陣列來記錄 dp  

所以若想求得 dp(i): 0 ~ i 的最大子陣列和, 可以先計算 dp(i-1) 再從以下取最大
- 從 dp(i-1) + num[i]
- num[i]

這意思是說如果 dp(i-1) + num[i] 如果小於 num[i]，那就直接從 num[i] 開始算子陣列

計算過程中，最大的 dp(i) 作為答案，因為最大子陣列和不一定以 nums[n-1] 作結尾

### 找出 dp 和下標的的意義

令 dp(n) 為在 nums<sub>0</sub>, ...,  nums<sub>n-1</sub> 中以 nums<sub>n-1</sub> 為結尾的最大子陣列和，換算成陣列，求 dp[n-1]

### 找出 dp 的狀態推導

dp[i] 的來源有以下
- 將 nums[i] 加入子陣列和，dp[i-1] + nums[i]
- 以 nums[i] 作為開頭，nums[i]

兩者取最大

### 找出 dp 初始值

dp[0] = nums[0]

### 複雜度

#### Time: O(n)
- 遍歷 nums: O(n)

#### Memory: On(n)
- dp 陣列的長度: O(n)

---

## Ver2 - Greedy

在 Ver1 中，因為 dp[i] 只和 dp[i-1] 有關，所以可以用一個變數來記錄  
curr: 包含當前元素的最大子陣列和  
result: 到目前為止的最大子陣列和  

### 複雜度

#### Time: O(n)
- 遍歷 nums: O(n)

#### Memory: O(1)

---

## Ver3 - Divide and Conquer

沒研究，以後再說...

### 複雜度

#### Time: O(n * log(n))

#### Memory: O()