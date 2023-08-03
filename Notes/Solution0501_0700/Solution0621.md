# Solution0621 Task Scheduler

這題不錯，用手算會可以算出答案，但是 generalize 不出規則來，所以就看解答了

## Ver1 - Pritority Queue



### 複雜度

#### Time: O()


#### Space: O()

---

## Ver2 - Greedy

算出出現最多的次數 maxFreq  
算出出現最多次數的工作數量 maxTasks

Max( tasks.Length, (maxFreq - 1) * (n + 1) + maxTasks )

這公式感覺有漏洞

例如 A: 3, B: 2, C: 2，n = 1，會感覺不對，不過實際上公式是對的  
會想排成: ABACABC，最後一個 C 感覺沒有 A 可以配對  
不過其實並沒有規定兩個 A 之間只能排一個工作，把它排作 ABCABCABCA 就的確是合法的，也就是 tasks 的長度



### 複雜度

#### Time: O()


#### Space: O()

## Ver3 - Greedy

也是挺神奇的解法...

算每輪的空格數