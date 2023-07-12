# Solution0024 Swap Nodes in Pairs

## Ver1 - Iterative

不難的題目  
因為容易忘記指標指到哪裡裡，最好在紙上先畫面再來想程式怎麼寫

我用了雙指標  
如果 node<sub>i</sub>, node<sub>i+1</sub> 應該要被交換的話  
我將 slow 指在 node<sub>i-1</sub>，fast 指在 node<sub>i+1</sub>  
交換完畢後，slow 指向 fast，fast 則指向下一個節點

### 複雜度

#### Time: O(n)
- 需要遍歷 n 個節點: O(n)

#### Space: O(1)

---

## Ver2 - Recursive

看了別人的寫法，才知道也可以用遞迴寫

### 複雜度

#### Time: O(n)
- 需要遍歷 n 個節點: O(n)

#### Space: O(n)
- 最多遞迴 n 層: O(n)