# Solution0647

## 我一開始的想法

s<sub>0</sub>, ..., s<sub>n-1</sub> 的回文字串數目 = dp(0, n)，換算成陣列，求 dp[0][n-1]

推導方面  
dp[0][j] 的來源
- dp[0][j-1]
- s<sub>i</sub> ~ s<sub>j</sub> 的回文字串總數，0 <= i <= j
兩者相加

雖然會過，可是複雜度很高

### 複雜度

#### Time: O(n<sup>3</sup>)

#### Space: O(n)

---

## 動態規劃

記錄 s<sub>i</sub> ~ s<sub>j</sub> 若為回文字串，dp[i][j] 為 true，反之為 false  
所以需要二維陣列，且只會計算右上半邊

dp[i][j] 在以下情況為 true
- 若 s<sub>i</sub> = s<sub>i+1</sub>
  - i = j
  - j - i = 1
  - dp[i+1][j-1] 也為 true

由以上推導可知，若 i 要從小到大跑迴圈，那麼 j 要從大到小跑迴圈  
或是 i 要從大到小跑迴圈，那麼 j 就從小到大跑迴圈  

#### Time: O(n<sup>2</sup>)

#### Space: O(n<sup>2</sup>)

--

## 雙指針

確定以 s<sub>i</sub> 為中心，擴散出去的回文字串總數  
確定以 s<sub>i</sub>, s<sub>i+1</sub> 為中心，擴散出去的回文字串總數  
0 <= i < n  

兩者相加即為答案

#### Time: O(n<sup>2</sup>)

#### Space: O(1)