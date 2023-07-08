# Solution0383 Ransom Note

## HashTable

用長度 26 的陣列儲存 magazine 的字元的出現次數  
再拿去跟 ransomNote 的字元比較，如果出現次數變負數，即代表不可能組成 ransomNote  

### 複雜度
- ransomNote 長度: n
- magazine 長度: m

#### Time: O(Max(n, m))

#### Space: O(1)