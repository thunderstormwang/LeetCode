# Solution0056 Merge Intervals

## 排序

依左邊界再依右邊界排序後，再逐一判斷是否可以與前一個區間合併即可

### 複雜度

#### Time: O(n * log(n))
- 排序: O(n * log(n))
- 逐一輪詢每個元素能否跟前一個合併: O(n)

取最大項: O(n * log(n))

#### Time: O(n)