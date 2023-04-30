# Solution0169

## 暴力法

輪詢一遍陣列，用 Hash Table 儲存每個數的出現次數，並記錄目前遇到的最多次數的數字

### 複雜度

#### Time: O(n)

#### Space: O(n)

---

## 

Majority Element 的定義是出現次數超過 n/2，所以整個陣列只有一個數能符合條件  
用 candidate 儲存目前遇到可能的 Majority Element

candidate 初始化為 nums[0]  
count 初始化為 1  

輪詢陣列
- count = 0，令 candidate = nums[i]
- 當 candidate == nums[i]，count += 1
- 當 candidate != nums[i]，count -= 1

### 複雜度

#### Time: O(n)

#### Space: O(1)