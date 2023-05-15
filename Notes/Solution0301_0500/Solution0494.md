# Solution0494

## 動態規劃 Ver1

很容易就想到算法，但很容易在細節卡住

從 num<sub>0</sub>, ..., num<sub>n-1</sub> 共 n 個數字任意做加或減，求和為 target 的組合數目 = dp(n, target)  
換算成陣列就是求 dp[n-1][target]

column 的數目最多到 2 * sum - 1，sum 為陣列所有數的總和

狀態推導就是 dp[i][j] = dp[i-1][j-nums[i]] + dp[i-1][j+nums[i]]
- 當 j-nums[i] < -sum，dp[i-1][j-nums[i]] 為 0
- 當 j+nums[i] > sum，dp[i-1][j+nums[i]] 為 0

但是會發現程式很不好寫...因為實際上陣列不能有負的 index，得做個平移，讓 [0] 代表 -sum，...，[sum] 代表 0，...，[2*sum] 代表 sum

---

## 動態規劃 Ver2

看解答將 dp[i][j] 轉化為來源，覺得很神奇
- dp[i+1][j+num<sub>i</sub>] += dp[i][j]
- dp[i+1][j-num<sub>i</sub>] += dp[i][j]

也就是 dp[i][j] 有值才將它往下帶，也因為總和是 sum，j+num<sub>i</sub> 再怎麼都不會超過 sum，也就省去檢查邊界的程式碼

---

## 動態規劃 - Ver3 01背包 2維陣列

這題想好久...，因為不是加就是減，也就是選擇做為加號或不選擇做加號，那麼就可以轉化為 01 背包。

假設陣列的總和為 sum，並假設正數和為 x，那麼負數和就是 -(sum-x)  
那麼 x + -(sum-x) = target  
移項後為 x = (target + sum) / 2

就轉化成 01 背包了，從 n 個數任意挑選，每個數字物品只能選或不選一次，放入容量 x 的容器，求能放入該容器的組合數目

我們還可以知道 Abs(target) > sum 或是 (target + sum) % 2 = 1 都代表沒有任何解

### 找出 dp 和下標的的意義

從 num<sub>0</sub>, ..., num<sub>n-1</sub> 共 n 個數字任意挑選，每個數字只能選或不選，求放入容量 x 的最大結果 = dp(n, x)

換算成陣列，dp[i][j] 的定義是從 i-1 個數字任意挑選，每個數字只能選或被選一次，能放入容量 j 的組合數目。0 <= i < n, 0 <= j <= x = (target + sum) / 2

也就是我們要算出 dp[n-1][x]

### 找出 dp 的狀態推導

dp[i][j] 有兩種可能
- 不選 num<sub>i</sub> 或者說無法放入 num<sub>i</sub>，dp[i][j] = dp[i-1][j]
- 選 num<sub>i</sub> ，意即從 i-1 個數挑選，求能放入容量 j - 數字<sub>i</sub> 的容器的最大結果，dp[i][j] = dp[i-1][j - num<sub>i</sub>]

將以上兩者相加

### 找出 dp 初始值

為了初始化方便，dp[i][0] = 1，0 <= i <= n，使用 i 個數字組合成零的數目一定是 1，而 row 的數目變成 n+1

dp[0][j] = 0，1 <= j <= target，使用 0 個數字組合成 j 的數目一定是 0，而 column 的數目也變成 target+1

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(n<sup>2</sup>)

---

## 動態規劃 - Ver4 01背包 1維陣列

從二維陣列改一維陣列需要顧慮的點有，前一個要被計算的數值不能被蓋掉

在狀態推導中，dp[i][j] 有二：
- dp[i-1][j]，也就是從上方傳下來，也可以說就是本身的前一個數值
- dp[i][j] = dp[i-1][j - num<sub>i</sub>]，不確定 j - num<sub>i</sub> 是多少，但肯定比 j 小

所以如果將 j 從由大到小走迴圈，就不用擔心前一個數值被蓋掉了

那麼就可以選用一維陣列，dp[j] = d[j] + dp[j - num<sub>i</sub>]

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(n)
