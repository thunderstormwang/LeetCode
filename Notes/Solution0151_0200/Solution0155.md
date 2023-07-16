# Solution0155 Min Stack

## Ver1

用兩個 stack 達成題目要求

_stack 是正常的 Stack

_minStack 在 Push 只在 _minStack 沒有元素時或 val <= _minStack 的頂端元素時才會放入  
_minStack 在 Pop 只在 _stack 取出的元素也跟 _minStack 的頂端元素相等時才會跟著做 Pop  

### 複雜度

#### Time: O(1)

#### Memory: O(n)