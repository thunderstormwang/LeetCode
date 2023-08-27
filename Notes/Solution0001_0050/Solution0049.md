# Solution0049 Group Anagrams

## Ver1

沒解出來，沒將問題 generalize 出來  
沒看過解答我絕對想不出來

將字串排序後，就可以分組，可以存在 Dictionary 裡，最後再轉成 List\<List\>

### 複雜度

#### Time: O(n * k * log(k))
- 共 n 個字串
- 每個字串排序: k * log(k)

#### Space: O(n * k)

---

## Ver2

在 C# 可以用一行 Linq 解決

### 複雜度

#### Time: O(n * k * log(k))
- 共 n 個字串
- 每個字串排序: k * log(k)

#### Space: O(n * k)