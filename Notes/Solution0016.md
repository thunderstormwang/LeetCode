# Solution0001

## 暴力法

跑三層迴圈

### 複雜度

#### Time: O(n<sup>3</sup>)

#### Space: O(1)

---

## Two Pointer

先做排序  
再輪詢每個元素 nums[i]，再用兩個指標
- low = nums[i+1]
- high = nums[n-1]

計算三者的和是否更接近 target  
接著移動指針其中之一，如果三者的和比 target 小，將 low + 1, 反之將 right - 1  
重覆以上步驟直到輪詢完所有元素  

### 複雜度

#### Time: O(n<sup>2</sup>)
排序 -- O(n * log(n))  
排序 -- O(n<sup>2</sup>)  
取最大項 -- O(n<sup>2</sup>)

#### Space: O(1)