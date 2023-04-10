# Solution0252

## 暴力法

nums[0] 跟 nums[1]~nums[n-1] 確認區間是否重疊  
...  
nums[n-2] 跟 nums[n-1] 確認區間是否重疊

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(1)

---

## 排序

先排序
- 將區間左邊界較小的往左排
- 將左邊界相同就將右邊界較小的往左排

如此一來，每個 nums[i] 只要跟 nums[i-1] 做比較即可

### 複雜度

#### Time: O(n * log(n))
排序 -- n * log(n)  
輪詢陣列 -- n  
取最大項 -- n * log(n)  

#### Space: O(1)