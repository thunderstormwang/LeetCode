# Solution0134

## 暴力法

逐一到每個元素檢查能否走完一圈

提交後會超時

### 複雜度

#### Time: O(N<sup>2</sup>)

#### Memory: O(1)

---

## 貪心解法

看到暴力法是 O(N<sup>2</sup>) 就猜想應該能用 O(n) 走完，

從位置 0 開始，將 gas[i] - cost[i] 累計到 currSum 和 totalSum  
如果輪詢到 nums[i] 發現 currSum 為 0，就代表從 0~i 任一點出發都會讓 gas 不夠，將 index 設為 i + 1 並將 currSum 歸零。  
輪詢完一輪陣列後，如果 totalSum 小於 0，就代表走不完一圈，直接回傳 -1，不然就回傳記錄的 index

雖然感覺可以這樣解，不過卻想不到何種方法可以證明此方法是正確的。就沒寫程式去試跑了。

### 複雜度

#### Time: O(n)

#### Memory: O(1)