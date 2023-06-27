# Solution0787 Cheapest Flights Within K Stops

## Ver1 - Breadth First Search

這題很容易就想到要用 BFS，轉幾次機就像要輸詢幾次 queue 的所有元素

建立鄰接表  
stop<sub>i</sub> -> stop<sub>j</sub>, 價錢  
...

將 [src, 0] 放入 queue，開始輪詢 queue  
從 queue 取出元素，stop<sub>i</sub>，從鄰接表找出所有它能到達的點 stop<sub>j</sub>，將 [stop<sub>j</sub>, 累積的價錢]  
如果在累計到 k 之前，queue 內就沒有元素可輪詢了，那就代表在 k 次轉機內，無法從 src 到 dst，回傳 -1

只計算到 dst 的最小價錢會得到 TLE，需要扣掉重覆的計算，要建立一個陣列 dist 維護從 src 到每個機場的最小價錢。  
從 queue 取出後，算出到其它能到的機場的最小價錢
- 算出的累積價錢比 dist 記錄得小，更新 dist，然後放入 queue
- 算出的累積價錢比 dist 記錄得大，放棄此記錄

### 複雜度
- 機場數: n
- flights 數目: n<sup>2</sup>
- 轉機次數: k < n
- 每個機場能到其它機場的平均數目: m < n

#### Time: O(n<sup>2</sup>)
- 建立 dist 陣列: O(n)
- 建立鄰接表: O(n<sup>2</sup>)
- 每個機場在每一輪清空 queue 的過程中都可能再被放入 queue: O(k * n * m)

相加後取最大: O(n<sup>2</sup>)

#### Space: O(n * m)
- 建立 dist 陣列: O(n)
- 建立鄰接表: O(n * m)
- queue 最多放入所有機場: O(n)

相加後取最大: O(n * m)

---

也可以用 DFS

---

## Ver2 - 動態規劃 - 2維陣列

### 找出 dp 和下標的的意義
令 dp[i][dst] 為在轉機次數在 i 次內從 src 到 dst 的最小價錢，換算成陣列要求 dp[k-1][dst]  
這會產生一個問題，如果是 0 次轉機會變成求 dp[-1][dst]  
所以要換個講法，轉機次數 k 就等於搭飛機次數 k + 1
令 dp[i][dst] 為搭飛機次數在 i 次內從 src 到 dst 的最小價錢，換算成陣列要求 dp[k][dst]，所以 dp 要初始化有 k + 1 個 row  

### 找出 dp 的狀態推導
dp[cnt][j] 的值為以下來源
- 如果 dp[cnt-1][i] 為無法到達，dp[cnt-1][j]
- 如果 dp[cnt-1][i] 為可到達，Min(dp[cnt-1][j], dp[cnt-1][i] + flights[i][j] 的價錢)

### 找出 dp 初始值
dp 皆初始為 int.MaxValue  
dp[i][src] 為 0，0 <= i <= k + 1，為了計算方便，將 row 的數目初始化為 k + 2

### 複雜度
- 機場數: n
- flights 數目: n<sup>2</sup>
- 轉機次數: k < n

#### Time: O()
- 初始化 dp: O(n * k)
- 輪詢 dp: O(k * n<sup>2</sup>)

#### Space: O(n * k)
- dp 的大小: O(n * k)

---

## Ver2 - 動態規劃 - 1維陣列

dp[cnt][j] 的來源有以下
- dp[cnt-1][j]
- Min(dp[cnt-1][j], dp[cnt-1][i] + flights[i][j] 的價錢)

i 跟 j 沒有絕對的大小關係，需要把 dp[cnt-1] 做備份，避免要拿來計算的值被蓋掉，才能計算

需要把 dp[i-1][j-1] 先存起來再作計算

```csharp
var temp = dist.ToArray();
for (var i = 0; i < flights.Length; i++)
{
    if (dist[flights[i][0]] == int.MaxValue)
    {
        continue;
    }
    
    temp[flights[i][1]] = Math.Min(temp[flights[i][1]], d[flights[i][0]] + flights[i][2]);
}
dist = temp;
```

#### Time: O()

#### Space: O()