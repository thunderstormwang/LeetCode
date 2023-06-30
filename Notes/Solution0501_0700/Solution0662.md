# Solution0662 Maximum Width of Binary Tree

## Ver1 - Depth First Search

完全沒頭緒..看完解答才知道做

為 binary tree 每個節點編號，將 root 編號為 1 開始，左子樹為 2 = 2 * i，右子樹為 3 = 2 * i + 1，如此就算同一層的中間有幾個節點為空，仍然可以算出每個節點的編號，  
求出每層中的最大寬度為最右邊的節點的編號 減去 最左邊節點的編號 + 1，找出最大值即是答案  

這做法可行，但很容易 overflow，只要 tree 的高度超過 64，那就超過 2<sup>64</sup>，就放不下了。  
需要做調整，每層的編號不一定要有連續性，讓每一層的最左邊的節點(即使為空節點)的編號從 0 開始，就不用擔心 overflow 了

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)

---

## Ver2 - Breadth First Search

同 Ver1，改用 BFS 方式

### 複雜度

#### Time: O(n)
- 最多遞迴 n 次: O(n)

#### Space: O(n)
- 最多遞迴 n 次: O(n)