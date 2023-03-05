# Solution0718

## 動態規劃 MyFirstAnswer 一維陣列

這題我第一次做就想到一維的解法, 不太好推，還是從二維推到一維較容易

想法上就是計算每個 nums1<sub>i</sub> 作結尾的最大連續子陣列長度，0 <= i < n

如果 nums2<sub>j</sub> = nums1<sub>i</sub> 
- 若 nums2<sub>j-1</sub> = nums1<sub>i-1</sub>
  - 一樣則 dp[i] = dp[i-1] + 1
  - 反之則為 + 1

在提交答案後發現 d[i-1] 會被蓋掉，就從 nums1 的尾巴開始跑迴圈

---

## 動態規劃 Ver1 二維陣列

### 找出 dp 和下標的的意義

以 nums1<sub>n-1</sub> 作結尾和 以 nums2<sub>m-1</sub> 作結尾的最大連續子陣列長度，換算成陣列，求 dp[n-1][m-1]

### 找出 dp 的狀態推導

dp[i][j] 的來源，0 <= i < n，0 <= j < m

- 若 nums1<sub>i</sub> = nums2<sub>j</sub>
  - 若 nums1<sub>i-1</sub> = nums2<sub>j-1</sub>，則為 dp[i-1][j-1] + 1
  - 反之則為 1

### 找出 dp 初始值

dp[0][j]，0 <= j < m
- 若 nums1<sub>0</sub> = nums2<sub>j</sub>，則為 1
- 反之為 0

dp[i][0]，0 <= i < n
- 若 nums1<sub>i</sub> = nums2<sub>0</sub>，則為 1
- 反之為 0

在計算 dp[n-1][m-1] 過程中，最大的 dp[i][j] 即為答案

### 複雜度

#### Time: O(nums<sub>1</sub> * nums<sub>2</sub>)

#### Memory: O(nums<sub>1</sub> * nums<sub>2</sub>)

---

## 動態規劃 Ver2 一維陣列

在狀態推導中，dp[i][j] 的來源
- dp[i-1][j-1] + 1，也就是上一列的 j-1
- 1

可以改用一維陣列 dp[j] = dp[j-1] + 1，同時為了避免要拿來計算的值被蓋掉，nums2 必須改從尾巴開始跑迴圈

### 複雜度

#### Time: O(nums<sub>1</sub> * nums<sub>2</sub>)

#### Memory: O(nums<sub>2</sub>)