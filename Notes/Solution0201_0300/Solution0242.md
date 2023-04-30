# Solution0242

## Dictionary

其實用長度 26 的陣列即可，因為會出現的字元只有小寫字母  
輪詢 s，array[s[i] - 'a']++  
輪詢 t，array[t[i] - 'a']--  
Anagram 的意思應該是每個字母都要而且也只能用到一次，所以我輪詢陣列，檢查 array[i] 是否都為 0

依照延申題目才需要用到 Dictionary

### 複雜度

#### Time: O(n)

#### Memory: O(1)

---

## 排序

### 複雜度

#### Time: O(n * log(n))
- 排序 s: O(n * log(n))
- 排序 t: O(n * log(n))
- 比較排序後的 s 和 t: n

#### Memory: O(1)