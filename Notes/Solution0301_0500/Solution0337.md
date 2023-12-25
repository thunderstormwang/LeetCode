# Solution0337 House Robber III

## Dynamic Programming

### 找出 dp 的狀態推導

每個節點要回傳兩種情況
- 選當前節點的金額，為以下之和
  - 當前節點金額
  - 不選左邊第一層 child 之金額
  - 不選右邊第一層 child 之金額
- 不選當前節點的金額，為以下之和
  - Max(選左邊第一層 child 之金額, 不選左邊第一層 child 之金額)
  - Max(選右邊第一層 child 之金額, 不選右邊第一層 child 之金額)

當 root 節點回傳後，看上述何者較大

### 找出 dp 初始值

當遞迴到當前節點為 null，選不選當前節點都是 0

### 複雜度

#### Time: O(n)
每個節點都要走過一次

#### Space: O(log(n))
樹的高度最高 log(n)，所以最多遞迴到 log(n)