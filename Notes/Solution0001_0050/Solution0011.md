# Solution0011 Container With Most Water

## 暴力法

輪詢陣列，在 nums[i] 皆往右計算每個能容納的水量  
在 nums[0] 要計算 n-1 次  
...  
在 nums[n-2] 要計算 1 次  

此方法會超時

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(1)

---

## Two Pointer

用雙指針，分別指向最左邊和最右邊，  
計算完容量後，將較矮的一端往內移動，因為移動較高的肯定不會得到更多的容量

### 複雜度

#### Time: O(n)

#### Space: O(1)