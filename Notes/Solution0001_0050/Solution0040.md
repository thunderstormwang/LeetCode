# Solution0040 Combination Sum II

## 回溯法

因為不能排到相同元素，需要先做排序。  
然後在每次遞迴時，如果 _candidates[i] 與 _candidates[i - 1] 相同，則往下個 i 前進。

### 複雜度

#### Time: O(2<sup>n</sup>)
- 排序: O(N * logN)
- 每個元素可以選或不選，總共有 2<sup>n</sup> 種組合: O(2<sup>n</sup>)

取最大項: O(2^n)

#### Space: O(n)
- 最多遞迴 n 層: O(n)