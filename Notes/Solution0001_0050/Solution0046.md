# Solution0046 Permutations

## Ver1 Backtrack(回溯)

用 used 記錄已被挑選的元素  
每層遞迴跑迴圈選擇還沒被挑選的元素，再呼叫下一層遞迴  
回到上層遞迴之前，要將 used 復原  

### 複雜度

#### Time: O(n!)
 - n 個元素一共有 n! 種排列: O(n!)

#### Space: O(n)
- 最多遞迴 n 層: O(n)
- used 長度: O(n)

---

## Ver2 Backtrack(回溯) - Swap

同 Ver1，改用元素交換的方法  
每層遞將 nums[index] 與 nums[i] 做交換，index <= i < num.Length，  
再呼叫下一層遞迴  
回到上層遞迴之前，要將 nums[index] 與 nums[i] 再交換回來  

### 複雜度

#### Time: O(n!)
 - n 個元素一共有 n! 種排列: O(n!)

#### Space: O(n)
- 最多遞迴 n 層: O(n)

---

## Ver3 Iteration

建立空的 list  
nums[0] 插入 list 有 1 個位置選擇，list 數量為 1  
nums[1] 插入 list 有 2 個位置選擇，list 數量為 2  
nums[2] 插入 list 有 3 個位置選擇，list 數量為 3  
...   
nums[n-1] 插入 list 有 n 個位置選擇，list 數量為 n

### 複雜度

#### Time: O(n!)
 - n 個元素一共有 n! 種排列: O(n!)

#### Space: O(1)
- O(1)