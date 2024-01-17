# Solution0028 Find the Index of the First Occurrence in a String

## Ver1 - 暴力法

### 複雜度
haystack 長度: n  
needle 長度: m  

#### Time: O(n*m)

#### Space: O(1)

---

## Ver2 - KMP

### 複雜度
haystack 長度: n  
needle 長度: m  

#### Time: O(n+m)
- 輪詢 needle 建立 LspArray: O(m)
- 輪詢 haystack: O(n)

#### Space: O(m)