# Solution0213 House Robber II

想法同 [Solution0198 House Robber](../Solution0151_0200/Solution0198.md)

情況有三：
- 情況一，頭尾都不考慮，從 num<sub>1</sub> ~ num<sub>n-2</sub>，選最大金額
- 情況二，不考慮尾，從 num<sub>0</sub> ~ num<sub>n-2</sub>，選最大金額
- 情況三，不考慮頭，從 num<sub>1</sub> ~ num<sub>n-1</sub>，選最大金額

情況二、三就會包含情況一了，只須計算此二情境

初始值跟 [Solution0198 House Robber](Solution0198.md) 不同，因為這次覺得這樣計算較容易

### 複雜度

#### Time: O(n)

#### Space: O(n)