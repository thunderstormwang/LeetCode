# Solution0128

## 暴力法

排序後找連續最長數列  
題目要求不可這樣做

### 複雜度

#### Time: O(n * log(n))
排序 -- n * log(n)  
輪詢陣列找連續最長數列 -- n  
取最大 -- n * log(n)  

#### Space: O(1)

## Ver1

輪詢一遍陣列，用 HashSet 儲存在陣列的數  

再輪詢一遍陣列
- 如果 nums[i]-1 存在於 HashSet，跳過 nums[i]
- 如果 nums[i]-1 不存在於 HashSet，代表找到該數列中最小的數，從 nums[i] 開始往上加 1 是否存在於 HashSet，就可以計算數列的長度

### 複雜度

#### Time: O(n)

#### Space: O(n)

---

## Ver2

用 Dictionary 儲存 nums[i] 的最長數列長度

輪詢一遍陣列
- 如果 nums[i] 存在於 Dictionary，代表已計算過，就跳過
- 如果 nums[i] 不存在於 Dictionary
  - 找 left，回傳 Dictionary[nums[i]-1]，不存在就回傳 0
  - 找 right，回傳 Dictionary[nums[i]+1]，不存在就回傳 0
  - 新的序列長度 count 為 left + 1 + right
  - 更新 Dictionary[nums[i]] = count，避免重覆計算
  - 更新 Dictionary[nums[i] - left] = count，更新序列長度
  - 更新 Dictionary[nums[i] + right] = count，更新序列長度

### 複雜度

#### Time: O(n)

#### Space: O(n)