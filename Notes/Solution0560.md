# Solution0001

## 暴力法 Ver1

從 nums[0] 計算到 nums[0]~nums[n-1] 的和，共計算 n<sup>2</sup> 次  
...  
從 nums[n-1] 計算到 nums[n-1] 的和，共計算 1 次  

### 複雜度

#### Time: O(n<sup>3</sup>)

#### Space: O(1)

---

## 暴力法 Ver2

同 Ver1，但採用累加的計算，因為 Sum(nums[0], ..., num[n-1]) 等於 Sum(nums[0], ..., num[n-2]) + nums[n-1]  
所以減少一層迴圈

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(1)

---

## Dictionary

如果 Sum(nums[i], ..., num[j]) 等於 k  
可以用 Sum(nums[0], ..., num[j]) - Sum(nums[0], ..., num[i]) 取得 Sum(nums[i], ..., num[j])  

如果 target = Sum(nums[0], ..., num[i]) - k 存在於 Dictionary，就代表多 Dictionary[targt] 個組合  
然後 Sum(nums[0], ..., num[i]) 當作 key 加進 Dicitonary，Value 為出現的次數  
供後續計算

### 複雜度

#### Time: O(n)

#### Space: O(n)