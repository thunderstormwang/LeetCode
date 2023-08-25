# Solution0050 Pow(x, n)

## Ver1 - Math - Recursive

如果直接跑迴圈，會 TLE，然後我就不會了...  
直接看解答。

用遞迴的方式，每次把 n 減半。  
如果該次遞迴的 n 是偶數，則回傳 half * half。  
如果該次遞迴的 n 是奇數，則回傳 half * half * x。  

### 複雜度

#### Time: O(log(n))
- 最多遞迴 log(n) 層: O(log(n))

#### Space: O(log(n))
- 最多遞迴 log(n) 層: O(log(n))

---

## Ver2 - Math - Iterative

也可以用迭代的方式，每次把 n 減半。  
會較難寫。

### 複雜度

#### Time: O(log(n))
- 最多遞迴 log(n) 層: O(log(n))

#### Space: O(log(n))
- 最多遞迴 log(n) 層: O(log(n))