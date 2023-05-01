# Solution0336

## 暴力法

每個字都去跟其它 n-1 個字串組合後，檢查是否為 palindrome

### 複雜度

#### Time: O(n<sup>2</sup> * k)
- n 個字串
- k 為組合後的最長字串長度

#### Space: O(1)

---

## Hash Table

好難...我只想得出暴力法，更進階的做法完全 generalize 不出來..    

用 Dictionary 儲存 (字串, index)  

輪詢 word，會有以下情況:  

一、本身就是 palindrome，尋找反轉後的
- 當 s[i] = "abba"，尋找空字串是否也存在於 Dictionary
  - 如果存在，那麼 [i, Dictionary[空字串]], [Dictionary[空字串], i] 都是符合的組合

二、全部字串反轉  
- 當 s[i] = "abcd"，尋找反轉後的字串 "dcba" 是否也存在於 Dictionary
  - 如果存在，那麼 [i, Dictionary["dcba"]] 也是符合的組合
  - 只加一邊是因為等輪到 s[j] = "dcba" 時，自然會會找到 [j, Dictionary["abcd"]]

三、部份字串反轉  
- 當 s[i] = "abcdd"，切成 left: "abc" 和 right: "dd"，當 right 是 palindrome，尋找反轉後的 left: "cba" 是否存在於 Dictionary
  - 如果存在，那麼 [i, Dictionary["cba"]] 也是符合的組合
- 當 s[i] = "ddabc"，切成 left: "dd" 和 right: "abc"，當 left 是 palindrome，尋找反轉後的 right: "cba" 是否存在於 Dictionary
  - 如果存在，那麼 [Dictionary["cba"], i] 也是符合的組合

這樣寫仍然超時，所以增加 set，儲存各字串的長度，在部份字串時，如果需要的反轉字串的長度存在，才去檢查另一邊字串是否為 palindrome

### 複雜度

#### Time: O(n * k<sup>2</sup>)
- n: 字串數目, k: 最長的字串長度
- 檢查每個字串是否是 palindrome: n * k
- 反轉整個字串: n * k
- 拆長度，然後檢查 palindrome 和 反轉子字串: 2 * n * k<sup>2</sup>

相加後取最大項: O(n * k<sup>2</sup>)

#### Space: O(n)