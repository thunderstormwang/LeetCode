# Solution1235

## 動態規劃 + Binary Search - Ver1

好難...

### 找出 dp 和下標的的意義
從 工作<sub>0</sub>, ..., 工作<sub>n-1</sub> 共 n 個工作任意挑選，每個工作只能選或不選，求最大收益 = dp(n)

換算成陣列，dp[n-1]

### 找出 dp 的狀態推導
dp[i] 有兩種可能
- 不選 工作<sub>i</sub> 或者說無法選擇 工作<sub>i</sub>，dp[i] = dp[i-1]
- 選 工作<sub>i</sub> ，意即從 i-1 個工作挑出一個 prevIndex，該工作<sub>prevIndex</sub> 的結束時間小於等於 工作<sub>i</sub> 的起始時間，工作<sub>i</sub> 的收益 + dp[prevIndex]

從以上兩者取最大

為此還需要  
- 對工作依結束時間排序  
- 用 Binaray Search 找尋 PrevIndex  

### 找出 dp 初始值
- dp[0] = 工作<sub>0</sub>0 的收益

### Binary Search

假如有三個工作，工作的開始和結束時間都一樣，都是 0~3，就收益不一樣: [10, 20, 30]  
由 dp 的推導可以知道，會算出
- dp[0] = 10
- dp[1] = 20
- dp[2] = 30

假設有第 4 個工作且開始時間是 3，它應該要拿 dp[2] 去計算才會被少算  
所以要辛算 dp[i] 的收益，要從已經計算過的 dp 中，找到最後一個結束時間 小於等於 工作<sub>i</sub> 的起始時間  
這情況就很適合用 Binary Search

我們無法直接判斷 array[middle] 是否就是我們要的最後一個結束時間 小於等於 工作<sub>i</sub> 的起始時間  
只能繼續往下找
- 當 array[middle] 結束時間 <= 工作<sub>i</sub> 的開始時間
  - 記錄 middle 到 PrevIndex
  - left = middle + 1
- 當 array[middle] 結束時間 > 工作<sub>i</sub> 的開始時間
  - right = middle - 1

### 複雜度

#### Time: O(n<sup>2</sup>)
- 排序: O(n * log(n))
- 一共有 n 個 job 使用 Binary Search: O(n * log(n))

加總後取最大: O(n * log(n))

#### Space: O(n)

---

## 動態規劃 + Binary Search - Ver2 - 01背包 - 二維陣列

當我看懂解答後，覺得這是 01 背包的變形，又看到陣列的長度是用工作數量  
開始疑惑為什麼不用所有工作的最大結束時間 MaxEndTime 做為陣列長度  

開始試著寫寫看，先從二維陣列開始

### 找出 dp 和下標的的意義
從 工作<sub>0</sub>, ..., 工作<sub>n-1</sub> 共 n 個工作任意挑選，每個工作只能選或不選，求最大收益 = dp(n, MaxEndTime)

換算成陣列，dp[n-1][MaxEndTime-1]

### 找出 dp 的狀態推導
dp[i][j] 有兩種可能
- 不選 工作<sub>i</sub> 或者說無法選擇 工作<sub>i</sub>，dp[i][j] = dp[i-1][j]
- 選 工作<sub>i</sub> ，意即從 i-1 個工作挑出一個 prevIndex，該工作<sub>prevIndex</sub> 的結束時間小於等於 工作<sub>i</sub> 的起始時間，工作<sub>i</sub> 的收益 + dp[i-1][prevIndex]

從以上兩者取最大  
也可以看在選 工作<sub>i</sub> 時，是跟 preIndex 有關係，也就是會算出重覆的數字 

我們仍需要  
- 我們需要對工作依結束時間排序  
- 我們需要用 Binaray Search 找尋 prevIndex  

### 找出 dp 初始值
- dp[i][0] = 0，0 <= i <= n，為了計算方便將 row 的數目改為 n+1
- dp[0][j] = 0，0 <= j <= MaxEndTime，為了計算方便將 column 的數目改為 MaxEndTime+1

範例就用  
startTime: { 1, 2, 3, 4, 6 }  
endTime: { 3, 5, 10, 6, 9 }  
profit: { 20, 20, 100, 70, 60 }  

| 縱座標為工作<br/>橫座標為時間 | 0 | 1 | 2 | 3  | 4  | 5  | 6  | 7  | 8  | 9   | 10  |
|-------------------------------|---|---|---|----|----|----|----|----|----|-----|-----|
| <b>0</b>                      | 0 | 0 | 0 | 0  | 0  | 0  | 0  | 0  | 0  | 0   | 0   |
| 工作<sub>0</sub>，1~3，20       | 0 | 0 | 0 | 20 | 20 | 20 | 20 | 20 | 20 | 20  | 20  |
| 工作<sub>1</sub>，2~5，20       | 0 | 0 | 0 | 20 | 20 | 20 | 20 | 20 | 20 | 20  | 20  |
| 工作<sub>2</sub>，4~6，70       | 0 | 0 | 0 | 20 | 20 | 20 | 90 | 90 | 90 | 90  | 90  |
| 工作<sub>3</sub>，6~9，60       | 0 | 0 | 0 | 20 | 20 | 20 | 90 | 90 | 90 | 150 | 150 |
| 工作<sub>4</sub>，3~10，100     | 0 | 0 | 0 | 20 | 20 | 20 | 90 | 90 | 90 | 150 | 150 |

感覺是可行，但是超時了....  
原因在於計算 dp[i][j] 時，如果選 工作<sub>i</sub> 的公式是 工作<sub>i</sub> 的收益 + dp[i-1][prevIndex]，只要 j >= 工作<sub>i</sub> 的結束時間，都會計算出同樣的值，也就是作重覆的計算，然後 LeetCode 就用了龐大的數據來讓你過不了

### 複雜度

#### Time: O(n * MaxEndTime)
- 排序: O(n * log(n))
- 一共有 n 個 job 使用 Binary Search: O(n * log(n))
- 因為題目說 endTime<sub>i</sub> <= 10<sup>9<sup>，不是能忽略不計的成本

加總後取最大: O(n * MaxEndTime)

#### Space: O(n * MaxEndTime)

---

## 動態規劃 + Binary Search - Ver2 - 01背包 - 一維陣列

改用一維陣列，仍會超時