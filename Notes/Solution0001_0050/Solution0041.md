# Solution0041 First Missing Positive

## Swap

這題若沒限制 O(1) 空間，就很簡單，用 HashSet 即可  
因為限制了 O(1) 空間，就使用原本的陣列 nums

遍歷陣列，將 nums[i] 放在 i + 1 的位置上，也就是讓  
nums[0] = 1  
nums[1] = 2  
nums[2] = 3  
nums[3] = 4  
...  

如果遇到 nums[i] != i + 1 的，就將 nums[i] 和 nums[nums[i] - 1] 作交換，以達成上述的順序  

很難一次過，提交後才會發現有沒想到的情況，所以這題才是 hard 吧  
遇到 nums[i] <= 0 或 nums[i] > nums.Length 就跳過，因為放不下也不影嚮後續計算  

還有要注意交換的元素是否已被蓋掉
這樣會錯  
```charp
var temp = nums[i];
nums[i] = nums[nums[i] - 1];
nums[nums[i] - 1] = temp;
```
因為 nums[i] 已被蓋掉，需要這樣寫
```charp
var temp = nums[i];
nums[i] = nums[nums[i] - 1];
nums[temp - 1] = temp;
```

還有因為題目沒有說明元素不會重覆，當 nums[i] 跟 nums[nums[i] - 1] 相等時，也不用作交換，避免進入無窮迴圈

### 複雜度

#### Time: O(n)
- 遍歷陣列，將元素放到對的位置: O(n)
- 遍歷陣列，尋找位置不對的元素: O(n)

#### Space: O(1)