# Solution0227 Basic Calculator II

本來以為將輸入字串轉成 postorder，結果是自己想太多  
好難，最好先寫 psuedo code 列出所有情況再寫程式碼

用 stack 儲存數字  
如果當前數字的前一個是運算符合
- '+' 號，將當前數字放入 stack
- '-' 號，將當前數字取負號放入 stack
- '*' 號，將前一個數字與當前數字作乘法後再放入 stack
- '/' 號，將前一個數字與當前數字作除法後再放入 stack

最後將 stack 內所有數字相加

## Ver1 - Stack

看完上述解法，因為需要知道前一個是什麼運算符號，我宣告 stack 儲存字串，方便連運算符號也存進，想當然爾，寫出來的程式碼比解答複雜多了

遍歷字串
- 如果 s[i] 為空白，跳過
- 如果 s[i] 為 +、-、*、/，將 s[i] 放入 stack
- 如果 s[i] >= '0' 且 s[i] <= '9'
  - 完整讀完數字，假設為 temp
  - 如果 stack.Peek() 是 '+'，將 temp 放入 stack
  - 如果 stack.Peek() 是 '-'，將 -1 * temp 放入 stack
  - 如果 stack.Peek() 是 '*'
    - stack.Pop()
    - nums1 = stack.Pop()
    - stack.Pusj(num1 * temp)
  - 如果 stack.Peek() 是 '/'
    - stack.Pop()
    - nums1 = stack.Pop()
    - stack.Pusj(num1 / temp)

遍歷完字串，stack 只會剩下數字，將這些數字相加即是結果

### 複雜度

#### Time: O(n)
- 遍歷每個字元: O(n)

#### Space: O(n)
- stack 最多放 n 個字元: O(n)

---

## Ver2 - Stack



### 複雜度

#### Time: O(n)
- 遍歷每個字元: O(n)

#### Space: O(n)
- stack 最多放 n 個字元: O(n)