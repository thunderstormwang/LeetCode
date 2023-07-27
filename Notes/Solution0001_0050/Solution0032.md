# Solution0032 Longest Valid Parentheses

## 暴力法

在 s[i] 檢查長度的有效括孤字串長度

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(n)

---

## Ver1 - Stack

從暴力法可以看出，如果 s[i] ~ s[j] 內是有效括孤字串，那麼從 s[i+1]~s[j] 出發算出的有效括孤字串長度都不會比從 s[i] 來得高，也就這些重覆的計算可以避免

用 stack 記錄 '(' 的位置  
令 start 初始為 0

當遇到 s[i] == '('，就 stack.Push(i)  
當遇到 s[i] == ')' 且 stack 為空，代表需要重置，令 start = i
當遇到 s[i] == ')' 且 stack 不為空，計算當前長度
- stack.Pop
- 當前有效長度 length = stack.Count == 0 ? i - start + 1 : i - stack.Peek()

### 複雜度

#### Time: O(n)
- 需要遍歷整個字串: O(n)

#### Space: O(n)
- 最多需要儲存 n 個字元: O(n)

---

## Ver2 - Dynamic Programming

以後再研究

### 複雜度

#### Time: O()

#### Space: O()
