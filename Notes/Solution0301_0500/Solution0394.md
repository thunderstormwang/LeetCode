# Solution0394 Decode String

## Ver1 - Iterative

做過 [Solution0224](../Solution0201_0300/Solution0224.md)、[Solution0227](../Solution0201_0300/Solution0227.md) 會覺得有大概的想法  
但還是沒做出來，我只想用一個 stack 存數字和字串，這會讓情況變得複雜

初始兩個 stack，countStack 放數字，strStack 放字串

遍正字串 s
- 當 s[i] 為數字
  - number = number * 10 + s[i]
- 當 s[i] == '['
  - countStack.Push(number)
  - strStack.Push(空字串)
- 當 s[i] 為小寫字母
  - strStack.Peek().Append(s[i])
- 當 s[i] == ']'
  - temp = strStack.Pop()
  - count = countStack
  - strStack.Peek().Append(temp)，重覆 count 次

最後 strStack 只會剩一個元素，即是答案

### 複雜度

#### Time: O(n)
- 遍歷每個字元: O(n)

#### Space: O(n)
- stack 最多放 n 個字元: O(n)

---

## Ver2 - Recursieve

遞迴很難看懂，先跳過...