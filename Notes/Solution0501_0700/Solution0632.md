# Solution0632 Smallest Range Covering Elements from K Lists

這題不錯，用手算會可以算出答案，但是 generalize 不出規則來，所以就看解答了

## 暴力法

用遞迴跑每種組合，找出最小的範圍

### 複雜度
- nums 中有 k 個陣列
- nums[k] 平均有 n 個元素

#### Time: O(n<sup>k</sup>)
- 一共有 n<sup>k</sup> 種組合: O(n<sup>k</sup>)

#### Space: O(k)
- 最多遞迴 k 層: O(k)

---

## Ver1 - Priority Queue

運用 Priority Queue，儲存的元素是 tuple (int Value, int ListIndex)，以 Value 做排序  
建立陣列 ListIndexes，記錄每個 nums[i] 目前的 index  
遍歷 nums，將每個 nums[i] 的第一個元素加入 Priority Queue，然後以 currMax 記錄目前 Priority Queue 的最大元素
建立 result，設為 new int [] { priorityQueue.Peek().Value, currMax }

將 priorityQueue 的頂端元素移出，找出該元素的 ListIndex  
從 nums[ListIndex] 找出下一個元素來取代被移除的頂端元素，所以需要 ListIndexes 記錄目前每個 nums[i] 用到哪裡，  
更新 currMax，如果 currMax - priorityQueue.Peek().Value 小於 result[1] < result[0]，就要更新 result  
重覆上述過程直到某個 nums[i] 的元素被用完，因為再繼續進行的話，肯定不會有更小的範圍了

最後回傳 result

### 複雜度
- nums 中有 k 個陣列
- nums[k] 平均有 n 個元素

#### Time: O()
- 每次新增元素到 Priority Queue: O(log(k))，一共有 n*k 個元素，所以是 O(n * k * log(k))

#### Space: O(n)
- Priority Queue 的大小: O(k)
- 陣列 ListIndexes 的大小: O(k)

---

## Ver2 - Sliding Window + Two Pointer

其實是 [Solution0076](../Solution0051_0100/Solution0076.md) 的變形題，這次題號順序倒是對了  

運用可變大小的 Sliding Window，找出最小的範圍。  
將 nums 合併為一個陣列 array，每個元素都是一個 tuple (int Value, int ListIndex)，  
利用雙指針，left 和 right 都從 0 出發，  
right 往右擴充，直到符合要求，Sliding Window 每個 nums[i] 都至少包含到一個元素  
再換 left 往右縮減，並持續更新最小範圍，直到不符合要求，Sliding Window 沒有在每個 nums[i] 都至少包含到一個元素  
重覆上述過程直到 right 遍歷完 array

### 複雜度
- nums 中有 k 個陣列
- nums[k] 平均有 n 個元素

#### Time: O(n*k)
- 遍歷 array: O(n*k)

#### Space: O(n*k)
- array 的大小: O(n*k)
