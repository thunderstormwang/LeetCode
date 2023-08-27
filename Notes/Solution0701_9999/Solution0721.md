# Solution0721 Accounts Merge

好難...，我發覺我在量少的情況都是硬解，無法想出 generalize 的解法，那當然寫不出程式  
看懂別人怎麼解後，也覺得難向人解釋解法...  
看到討論區在說，這題目根本不該算在 medium，才有安慰到我

## DFS

將每個 email 視為不同的組，並以自身為 root，如果發現有兩點 email 為同組，將其中一個的 email 的 root 也指到另一個 email

假設輸入如下:  
0 : [John, a@mail, b@mail]  
1 : [John, c@mail, d@mail]  
2 : [John, e@mail, a@mail, c@mail]  

建立 Dictionary owner，從 email 對應到 account  
owner[a]: John  
owner[b]: John  
owner[c]: John  
owner[d]: John  
owner[e]: John  

建立 Dictionary root，初始將每個 email 的本身做為一個群組，將其本身做為父  
root[a]: a  
root[b]: b  
root[c]: c  
root[d]: d  
root[e]: e  

再次輪詢 accounts，以第一個 email 為父，其它後面的 email 改將它設為父
經過此步驟，會將同帳號 email 連在一起  

輪詢 account[0]，a 和 b 被視為同一組  
root[a]: a  
root[b]: a  

輪詢 account[1]，c 和 d 被視為同一組  
root[c]: c  
root[d]: d  

輪詢 account[2]，e, a 和 c 被視為同一組  
root[e]: e  
root[a]: e  
root[c]: e  

如此 e 為 a, b, c, d 的父(找每個 email 的父需要用到遞迴)，也就找到同帳號的所有 email，那再藉由 owner，就可以找到每個 email 對應的帳號

### 複雜度
- accounts 的長度: n
- accounts[i] 的最大長度: k

#### Time: O(n * k * log(n * k))
- 初始化 root 和 owner: O(n * k)
- 設定 root: O(n * k)
- 設定 mergeAccount: O(n * k)
- 排序，最差情況是所有 email 都屬於同一個帳號: O(n * k * log(n * k))

取最大項: O(n * k * log(n * k))

#### Space: O(n * k)
- root 最多放 n * k: O(n * k)
- owner 最多放 n * k: O(n * k)
- mergeAccounts 最多放 n * k: O(n * k)

---

## BFS

記錄每個 email 分別在哪些 accounts 出現過，從 accounts[0] 開始輪詢 email，輪詢 email 的過程只要能找到未訪問過的 account[i]，就繼續輪詢，輪詢 account 過程中所輪詢過的 email 都屬於同一個帳號  

假設輸入如下:  
0 : [John, a@mail, b@mail]  
1 : [John, c@mail, d@mail]  
2 : [John, e@mail, a@mail, c@mail]  

建立 Dictionary emailAccountDict，找出每個 email 在哪些帳號出現過  
emailAccountDict[a]: [0, 2]  
emailAccountDict[b]: [0]  
emailAccountDict[c]: [1, 2]  
emailAccountDict[d]: [1]  
emailAccountDict[e]: [2]  

接著建立陣列 visited 記錄每個帳號是否已被訪問，  
還有建立 queue 記錄要輸詢的陣列。

輪詢 account[0]，發現 visited[0] 沒訪問過，放入 queue  

再從 queue 取出元素(此時為 account[0])，標記 visited[0] 已被訪問過，  
account[0] 有 email 如右 [a, b]，從 emailAccountDict 可知分別對應到帳號 [0, 2], [0]，因為 visited[0] 已訪問過，只把 account[2] 放入 queue。  
再從 queue 取出元素(此時為 account[2])標記 visited[2] 已被訪問過，  
account[2] 有 email 如右 [e, a, b]，從 emailAccountDict 可知分別對應到帳號 [2], [0, 2], [1, 2]，因為 visited[0], visited[2] 已訪問過，只把 account[1] 放入 queue。  
再從 queue 取出元素(此時為 account[1])，標記 visited[1] 已被訪問過，  
account[1] 有 email 如右 [c, d]，從 emailAccountDict 可知分別對應到帳號 [1, 2], [2]，因為 visited[0], visted[1], visited[2] 已訪問過，queue 不會被新增元素。

如此一來，在 queue 的元素變為空之前所輪詢的 email 都屬於同一個帳號  

重覆上述步驟直到所有帳號都被訪問過  

### 複雜度
- accounts 的長度: n
- accounts[i] 的最大長度: k

#### Time: O(n * k * log(n * k))
- 設定 emailAccountDict: O(n * k)
- 每個 account[i] 只會被放入 queue 一次，且 account[i] 所有 email 會被遍歷一次: O(n * k)
- 排序，最差情況是所有 email 都屬於同一個帳號: O(n * k * log(n * k))

#### Space: O(n * k)
- emailAccountDict 最多放 n * k: O(n * k)
- visited 最多放 n: O(n)
- queue 最多放 n: O(n)