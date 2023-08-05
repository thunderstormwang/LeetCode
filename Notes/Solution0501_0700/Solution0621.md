# Solution0621 Task Scheduler

這題不錯，用手算會可以算出答案，但是 generalize 不出規則來，所以就看解答了

## Ver1 - Pritority Queue

每個循環能放 n + 1 個工作，且一定要放入最多數量的工作

用 priorityQueue 維護工作數量  
每個循環優先從工作數量多的工作開始排，所以從 priorityQueue 取出 n + 1 個工作，  
將取出的工作的工作數量減 1，如果仍 > 0，需要再放回 priorityQueue
重覆上述過程，直到 priorityQueue 為空

### 複雜度

#### Time: O(n)
- 遍歷 tasks: O(n)
- 從 priorityQueue 取出工作後，可能會再放回去: log(26)，總共有 n 個 工作數目: O(n)

#### Space: O(n)
- 用 array 計算每個工作的數量: O(1)
- priorityQueue 最多存 26 個工作: O(1)

---

## Ver2 - Greedy

算出出現最多的次數 maxFreq  
算出出現最多次數(maxFreq)的工作數量 maxTasks  
我們至少要做 maxFreq - 1 個循環，每個循環放 n + 1 個工作，最後再加 maxTasks  
將上述寫成公式:  
> (maxFreq - 1) * (n + 1) + maxTasks  

但是這公式有漏洞，例如 A: 4, B: 3, C: 3，n = 1，會算出 3 個循環 * 2 個工作 + 1 = 7，與實際情況不符，實際上至少需要 10 個工作時間才能完成所有工作。  
這不代表公式是錯的，實際上 3 個循環是對的，是每個循環的工作放太少。
如果這樣排列: ABCABCABCA，就會發現的確是放滿 3 個循環，也就要考慮工作的總數量，將公式修改為  
> Max( tasks.Length, (maxFreq - 1) * (n + 1) + maxTasks )

### 複雜度

#### Time: O(n)
- 遍歷 tasks: O(n)

#### Space: O(1)
- 計算 26 個工作的數量: O(1)

---

## Ver3 - Greedy

跟 Ver2 一樣是公式解，不同的是，這裡是算聞置的空檔數  

算出出現最多的次數 maxFreq  
算出出現最多次數(maxFreq)的工作數量 maxTasks  
在每個循環排除最多數目的工作後，計算還能能納的空檔數: 
> emptySlots = ((n+1) - maxTasks) * (maxFreq - 1)

排除最多數目的工作後，計算剩下的工作數量:
> leftTasks = task.Length - maxTasks * maxFreq

- 如果 emptySlots > leftTasks，即代表剩餘的工作數量都可排入空檔數，且還會有聞置的空檔數，也就是需要安插閒置的空檔時間才能完成所有工作
- 如果 emptySlots <= leftTasks，即代表不會有閒置的空檔數，也就是不用閒置的空檔數即可完成所有工作

所以公式為:
> tasks.Length + Max(0, emptySlots - leftTasks)

### 複雜度

#### Time: O(n)
- 遍歷 tasks: O(n)

#### Space: O(1)
- 計算 26 個工作的數量: O(1)