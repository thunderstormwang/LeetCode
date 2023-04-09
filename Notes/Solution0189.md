# Solution0189

## Ver1

k 如果大於等於 nums.Length，等於多繞一圈，可以去掉  

如果想用迴圈方式
```csharp
var pre = nums[pos];
var temp = nums[(pos + k) % nums.Length];
nums[(pos + k) % nums.Length] = pre;
pre = temp;
```
判斷當 pos 回到 0 就等於全部換完時  
就會中陷井，，當 nums.Length 和 k 的最小公因數不為 1 時，迴圈會比預期地快結束，例如 nums.Length 為 4，k = 2，你只會走到 nums[0], nums[2] 就結束了，不會走到 nums[1], nums[3]

所以迴圈要判斷條件要改成交換元素的次數是否等於 nums.Length  
當 pos 回到原位置時，要將 pos + 1 再繼續迴圈

### 複雜度

#### Time: O(n)

#### Memory: O(1)

---

## Ver2

以 1, 2, 3, 4, 5, 6, 7 為例，且 k = 3  

先全部反轉，7, 6, 5, 4, 3, 2, 1  
因為 k = 3，再將三個元素反轉，5, 6, 7, 4, 3, 2, 1  
最後將後四個元素反轉，5, 6, 7, 1, 2, 3, 4  
這就是答案

真神奇..

### 複雜度

#### Time: O(n)

#### Memory: O(1)