# Solution0096

## 動態規劃

在這題栽了...狀態推導想錯方向

原本我想的狀態推導是，已經排好的 Binary Search Tree dp[i-1]，要加入節點 i 時，有以下方式
- 加在 root
- 放在 node<sub>i-1</sub> 的右下
- 取代 node<sub>i-1</sub> 的位置，然後將 node<sub>i-1</sub> 放在 node<sub>i</sub> 的左下

但這種方式在 N = 1~4 時都是對的，到 N = 5 時出錯了

### 找出 dp 的意義：
在 n 個節點所組成的不同的 Binary Search Tree 的數目 = dp(n)

### 找出 dp 的狀態推導：
dp[i] 為以下之和：

左邊 0 個節點的組合 * 右邊 i-1 個的組合

...

左邊 i-1 個節點的組合 * 右邊 0 個的組合

也就是 dp[i] = SUM(dp[j] * dp[i-j])，0 <= j < i，1 <= i <= n
  
### 找出 dp 初始值：
dp[0] = 1

### 複雜度

#### Time: O(n<sup>2</sup>)

巢狀迴圈

i = 1，計算 1 次

...

i = n，計算 n-1 次

用梯形公式，(1 + (n-1)) * (n) / 2，取最大項，所以是 n<sup>2</sup>

#### Space: O(n)