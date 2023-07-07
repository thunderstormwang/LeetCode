# Solution0437 Path Sum III

## Ver1 暴力法

雙重遞迴，第一層遞迴到每個節點，然後開始第二層遞迴計算累計的
path sum，有符合就加 １

很意外這樣可以過...
測資裡有 10 位數，得將型態轉為 log，不然會 overflow

### 複雜度

#### Time: O(n<sup>2</sup>)
- 在每個節點做遞迴，最多會遞迴 n 層，所以 n*n : O(n<sup>2</sup>)

#### Space: O(n)
- 最多遞迴 n 層

---

## Ver2 遞迴 和 HasbTable

跟 [Solution0560](../Solution0501_0700/Solution0560.md) 一樣的解法，我又忘了...
所以 leetcode 的順序很爛，將變型題擺在基本題型的前面

遞迴時，計算累計的路徑總和 currSum  
如果 dict[currSum - targetSum] 存在，將此值計入結果    
dict[currSum] += 1  
遞迴呼叫傳入子節點  
dict[currSum] -= 1  
回傳當前節點結果 加上 子節點回傳的結果  

### 複雜度

#### Time: O(n)
- 需要遍歷迴 n 個節點: O(n)

#### Space: O(n)
- dict 最多有 n 個值: O(n)
- 最多遞迴 n 個節點: O(n)