# Solution0152 Maximum Product Subarray

[Solution0053](../Solution0051_0100/Solution0053.md) 的變形題

## Ver1 - Dynamic Programming

一開始有隱約想到要記錄最小值，但沒有動手試試的意思，不然就靠自己想出來了

如果像 [Solution0053](../Solution0051_0100/Solution0053.md) 一樣，只記錄最大值，那麼在陣列有兩個以上的負數的時候會算錯  
例如 [2, 3, -2, -4]  

所以為了負數的存在，我們需要把最大值和最小值都記錄下來

也因為最大子陣列和不一定是以 nums[n-1] 結尾，所以我們要在記算過程中，找出最大的 maxDp[i]

### 找出 dp 和下標的的意義

令 max_dp(n) 為在 nums<sub>0</sub>, ...,  nums<sub>n-1</sub> 中以 nums<sub>n-1</sub> 為結尾的最大子陣列乘積和，換算成陣列，求 maxDp[n-1]  
令 min_dp(n) 為在 nums<sub>0</sub>, ...,  nums<sub>n-1</sub> 中以 nums<sub>n-1</sub> 為結尾的最小子陣列乘積和，換算成陣列，求 minDp[n-1]

### 找出 dp 的狀態推導

maxDp[i] 的來源為以下求最大
- nums[i]
- maxDp[i-1] * nums[i]
- minDp[i-1] * nums[i]

minDp[i] 的來源為以下求最小
- nums[i]
- maxDp[i-1] * nums[i]
- minDp[i-1] * nums[i]

### 找出 dp 初始值
maxDp[0] = nums[0]  
minDp[0] = nums[0]

### 複雜度

#### Time: O(n)
- 遍歷 nums: O(n)

#### Memory: On(n)
- dp 陣列的長度: O(n)

---

## Ver2 - Dynamic Programming

maxDp[i] 和 minDp[i] 都只跟前一個有關，我們可以各只用一個變數作計算

### 複雜度

#### Time: O(n)
- 遍歷 nums: O(n)

#### Memory: On(1)

---

## Ver3 - Dynamic Programming

查網路，有人在 nums[i] 負數時，將 max 和 min 交換，這樣就不用再判斷 max * nums[i] 和 min * nums[i] 的大小了

### 複雜度

#### Time: O(n)
- 遍歷 nums: O(n)

#### Memory: On(1)