# Solution0017 Letter Combinations of a Phone Number

## Ver1 - Recursive - 深度優先

遞迴基本題，當需要找出所有可能時，應該將 result 放在參數傳遞，而不是當回傳值  

當前遞迴找到一個可能組合時，即往下呼叫遞迴，等下層遞迴回來時，再次往下呼叫遞迴，直到當前遞迴也找不到其它可能組合，才往上回傳

### 複雜度
- digits 長度: n

#### Time: O(4<sup>n</sup>)
- 最多有 4<sup>n</sup> 種組合: O(4<sup>n</sup>)

#### Space: O(n)
- 最多遞迴 n 層: O(n)

---

## Ver2 - Iterative - 廣度優先

用迭代找出所有答案

每次迭代都將當前 index 的所有可能性找出來

### 複雜度
- digits 長度: n

#### Time: O(n)
- 最多有 4<sup>n</sup> 種組合: O(4<sup>n</sup>)

#### Space: O(1)