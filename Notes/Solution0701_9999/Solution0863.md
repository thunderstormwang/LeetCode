# Solution0863 All Nodes Distance K in Binary Tree

好難...這題是 hard 吧  
用眼睛看圖找出符合的節點很簡單，要寫成程式就不會了  

重點在如何從 target 往外去找符合的節點

## Ver1 Depth First Search

用 parentDict 儲存子節點對父節點的對應  
用 visited 記錄是否已遍歷過該節點  

就可以從 target 出發，用遞迴的方式，往兩個子節點、父節點去找符合的節點

### 複雜度

#### Time: O(n)
- 建立 parentDict，需要遍歷 n 個節點: O(n)
- 找符合距離 k 的節點，最多要遍歷 n 個節點: O(n)

#### Space: O(n)
- parentDict 最多存 n 個節點: O(n)
- visited 最多存 n 個節點: O(n)
- 最多遞迴 n 層: O(n)

---

## Ver2 Breadth First Search

其實就是這題當作 graph 去解  
建立鄰接表 graph  
用 visited 記錄是否已遍歷過該節點  

就可以從 target 出發，用 BFS 的方式，往兩個子節點、父節點去找符合的節點

### 複雜度

#### Time: O()
- 建立 graph，需要遍歷 n 個節點: O(n)
- 找符合距離 k 的節點，最多要遍歷 n 個節點: O(n)

#### Space: O(n)
- graph 最多存 n 個節點: O(n)
- visited 最多存 n 個節點: O(n)
- queue 最多放 n 個節點: O(n)

---

## Ver3 - 雙重遞迴

第一層遞迴回傳與 target 的距離  
第二層遞迴尋找符合題意的節點  

第一層遞迴回傳與 target 的距離
- 當前節點為 null，回傳 -1
- 當前節點為 target，回傳 0
  - 開始第二層遞迴，往下找符合距離 k 的節點
- 兩個子節點皆回傳 -1，也回傳 -1
- 左子節點回傳 left >= 0
  - 如果 left + 1 = k，當前節點即為符合題意的節點其中之一，回傳 left + 1
  - 其它情況，開始第二層遞迴，往下找符合距離 k - (left + 2) 的節點
- 右子節點回傳 right >= 0
  - 如果 right + 1 = k，當前節點即為符合題意的節點其中之一，回傳 right + 1
  - 其它情況，開始第二層遞迴，往下找符合距離 k - (right + 2) 的節點

### 複雜度

#### Time: O(n)
- 第一層遞迴最多遍歷 n 個節點: O(n)
- 第二層遞迴不好估算，但也是 O(n)
  - 在 target 往下遞迴，是找第一層遞回沒找旳節點)
  - 逐層往上，也是找第一層遞迴找過的節點

#### Space: O(n)
同上，最多遞迴 n 層