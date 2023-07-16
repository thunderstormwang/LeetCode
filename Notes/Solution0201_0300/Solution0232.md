# Solution0232 Implement Queue using Stacks

## Ver1

題目已寫明要用兩個 stack  
_input 用在 Push  
_output 用在 Pop 和 Peek

在 _output 沒有元素時，才將 _input 的所有元素倒進 _output

這邊時間複雜度不直接用最壞情況 O(N) 的原因是：  
假設一個情況 push, push, push, .... 連續 N 個 push 後再接 N 個 pop  
第一次的 pop 會是 O(N), 之後的 pop 都會是 O(1)  
這就是 Amortized 的基本原理, 因為最壞情況不會一直發生, 那每次計算成本都用最壞情況去計算就顯得不合理  

### 複雜度

#### Time: Amortized O(1)

#### Memory: Amortized O(1)