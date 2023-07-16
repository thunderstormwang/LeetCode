# Solution0020 Valid Parentheses

## Ver1

用 stack  
看到 ')' 就要判斷 stack 頂部元素是是為 '('  
看到 ']' 就要判斷 stack 頂部元素是是為 '['  
看到 '}' 就要判斷 stack 頂部元素是是為 '{'  
其它情況則將字元存入 stack

### 複雜度

#### Time: O(n)
- 需要走完字串: O(n)

#### Memory: O(n)
- stack 可能需要存字串的所有字元: O(n)