# Solution0494

## 動態規劃

todo 待補充

很容易就想到推導

dp[i][j] = dp[i-1][j-nums[i]] + dp[i-1][j+nums[i]]，column 的範圍其實就是 2*sum + 1

但是會發現不好寫...因為實際上陣列不能有負的 index，得做個平移，[0] 為 -sum，...，[sum] 為 0，...，[2*sum] 為 sum

看解答將 dp[i][j] 轉化為來源，覺得很神奇
- dp[i+1][j+num<sub>i</sub>] += dp[i][j]
- dp[i+1][j-num<sub>i</sub>] += dp[i][j]

---

## 動態規劃 - 01背包 2維陣列

這題想好久...很難想做是 01 背包，因為不是加就就是減，跟選或不選扯不上邊。

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

dp[0][0] = 1，不選 num<sub>0</sub> 且總和為 0 的組合有 1

dp[0][num<sub>0</sub>] = 1，選 num<sub>0</sub> 且總和為 num<sub>0</sub> 的組合有 1

要注意 num<sub>0</sub> 可能比 (target + sum) / 2 還大，那就造成 index out of range 了，所以就令 dp[-1][0]為 1，不用任何數的總和為 0 的組合有 1

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(n<sup>2</sup>)

---

## 動態規劃 - 01背包 1維陣列

從二維陣列改一維陣列需要顧慮的點有，前一個要被計算的數值不能被蓋掉

在狀態推導中，dp[i][j] 有二：
- dp[i-1][j]，也就是從上方傳下來，也可以說就是本身的前一個數值
- dp[i][j] = dp[i-1][j - num<sub>i</sub>]，不確定 j - num<sub>i</sub> 是多少，但肯定比 j 小

所以如果將 j 從由大到小走迴圈，就不用擔心前一個數值被蓋掉了

那麼就可以選用一維陣列，dp[j] = d[j] + dp[j - num<sub>i</sub>]

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(n)
