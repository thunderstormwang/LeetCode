# Solution0078 Subsets

## Ver1 - Backtrack

每層遞迴有選和不選 nums[index] 兩種選擇  
然後呼叫下層遞迴  
如果 index = nums.Length 代表已找到一種組合，開始往上回傳

### 複雜度

#### Time: O(2<sup>n</sup>)
- 一共有 2<sup>n</sup> 種組合: O(2<sup>n</sup>)

#### Space: O(n)
- 最多遞迴 n 層: O(n)

---

## Ver2 - Backtrack

每層遞迴一開始即記錄現在結果  
然後跑迴圈從 index <= i < nums.Length 挑一個元素 nums[i]  
然後讓下一層遞迴從 i + 1 開始挑元素

### 複雜度

#### Time: O(2<sup>n</sup>)
- 一共有 2<sup>n</sup> 種組合: O(2<sup>n</sup>)

#### Space: O(n)
- 最多遞迴 n 層: O(n)