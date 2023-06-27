# Solution0518

## 暴力法

從 nums[0] 計算到 nums[1]~nums[n-1] 的相同數量的0 和 1 的最大長度  
...  
從 nums[n-2] 計算到 nums[n-1] 的相同數量的0 和 1 的最大長度  

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(1)

---

## HashTable

這題好難呀，我一開始往動態規劃的方向去想，發現到不適合，接著就 generalize 不出規則來

輪詢陣列，遇到 0 就減 1，遇到 1 就加 1，將結果統計至 sum  
再用 Dictionary 儲存 (sum, index)
如果發現 sum 已存在於 dict，就代表 dict[sum] ~ i 有相同數量的 0 和 1，才會又回到 sum，那麼這段長度就是 i - (dict[sum] + 1) + 1，化簡為 i - dict[sum]  
最後算出的最大長度就是答案
注意 Dictionary[0] 要先初始化為 -1，不然輸入 [0, 1] 會錯誤

### 複雜度

#### Time: O(n)

#### Space: O(n)