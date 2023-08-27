# Solution0139 Word Break

## Ver1 - Trie

建立 Trie 的資料結構  
建立陣列 dp，dp[i] 為 s[0] ~ s[i-1] 是否能匹配成功

遍歷 s，對於每個 s[i]，如果 i = 0 或 dp[i-1] 為 true，代表 s[0] ~ s[i-1] 能匹配成功，可以嘗試繼續匹配。  
令 j = i，從 Trie 的根節點開始往下找 s[j]，  
- 如果找到一個 TrieNode，且 TrieNode.isWord 為 true，那麼 dp[j] = true  
- 如果找不到 TrieNode，就放棄，換下一個 i

最後回傳 dp[n-1]  
  
其實會發現建立 Trie 不是很必要，可以像 Ver2 一樣直接用動態規劃去解

### 複雜度
- s 的長度: n
- wordDict 的長度: m
- wordDict[i] 的平均長度: k

#### Time: O(n * m)

#### Space: O(n + m * k)
- dp 的長度: O(n)
- Trie 的長度: O(m * k)

---

## Ver2 - Dynamic Programming

網路上也有人將此題看作 [Solution0322](../Solution0301_0500/Solution0322.md) 的變形，將它當作完全背包去解，這也說得通。  
但很難寫出二維陣列的解法，直接寫一維陣列會較容易。  

### 找出 dp 和下標的的意義

長度 n 的字串是否能匹配成功 = dp(n)，  
換算成陣列，找 dp[n-1]

### 找出 dp 的狀態推導

在 d[j] 這位置，只要能找到一個 word<sub>i</sub>，使得 d[j - word<sub>i</sub> 的長度] 為 true，那麼 d[j] 也就為 true，反之為 false

### 找出 dp 初始值

為了初始化方便，令 d[0] 為 true，所以 column 的數目多 1，那麼就改成求 dp[n]

### 複雜度
- s 的長度: n
- wordDict 的長度: m

#### Time: O(n * m)
- 遍歷 s，且在 s[i] 往回推是否符合任一在 wordDict 的字串: O(n * m)

#### Space: O(n)
- dp 陣列的長度: O(n)