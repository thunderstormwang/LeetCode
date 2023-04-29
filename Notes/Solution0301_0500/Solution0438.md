# Solution0438

## 暴力法

在 s[0] 比較 s[0]~s[p.Length-1] 和 p
...  
在 s[s.Length-p.Length] 比較 s[s.Length-p.Length]~s[s.Length-1] 和 p

### 複雜度

#### Time: O(n * k)
- n 為字串 s 的長度
- k 為字串 p 的長度

#### Space: O(k)
- k 為字串 p 的長度

---

## Sliding Window

跟 [Solution0076](../Solution0051_0100/Solution0076.md) 很像，不過較簡單

陣列 array 記錄 p 的字母出現次數

輪詢 s，並維護長度為 p.Length 的 Slding Window  
右邊新進的字母，在 array 中加 1  
左道被移出的字母，在 array 中減 1  
如果在 s[i] 時，array 中沒有大於 0 的字母，代表 i 符合要求

### 複雜度

#### Time: O(n)
- n 為字串 s 的長度

#### Space: O(1)