# Solution0518

## 動態規劃 - 完全背包 1維陣列

跟 [Solution0518](Solution0518.md) 就差在迴圈的順序

我的解讀是 d[j] 可能是和為 j 的排列數

d [j] = d[j - num<sub>n-1</sub>] + ... + d[j - num<sub>0</sub>]

### 複雜度

#### Time: O( n * target )

#### Space: O(target)

---

## 動態規劃 - 完全背包 2維陣列

寫不出來...在二維陣下，for 迴圈的順序不影響計算結果

只有在一維陣列時才有差