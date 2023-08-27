# Solution0153 Find Minimum in Rotated Sorted Array

二分法的變型，主要還是找出怎麼切半的方法

與 [Solution0033](../Solution0001_0050/Solution0033.md) 類似  
但我還是做得卡卡的

## Ver1

自己想的方法

列出陣列數為 5 的所有情形

情況一  
第一輪 1 2 3 4 5，順序是 左中右，往左  
第二輪 1 2 3，順序是 左中右，往左
第三輪 1 2，兩個直接比大小

情況二  
第一輪 5 1 2 3 4，順序是 中右左，往左  
第二輪 5 1 2，順序是 左中右，往左 
第三輪 5 1，兩個直接比大小

情況三  
第一輪 4 5 1 2 3，順序是 中右左，往左  
第二輪 4 5 1，順序是 右左中，往右  
第三輪 5 1，兩個直接比大小

情況四  
第一輪 3 4 5 1 2，順序是 右左中，往右  
第二輪 5 1 2，順序是 中右左，往左  
第三輪，1 2，兩個直接比大小

情況五  
第一輪 2 3 4 5 1，順序是 右左中，往右
第二輪 4 5 1，順序是 右左中，往右  
第三輪 5 1，兩個直接比大小

可以看出當 左中右、中右左 時要往左找，當右左中 時 要往右找
也因為無法排除 middle 可能就是最小值  
取左半邊是用 right = middle  
取右半邊是用 left = middle  
如果迴圈終止條件仍用 left <= middle 那麼可能會進入無窮迴圈，將終止條件改為 right - left > 1  
剩兩個元素時，就直接比較了

### 複雜度

#### Time: O(log(n))

#### Space: O(1)

---

## Ver2

看完解答才知自己還是想得不夠透徹  

在 Ver1 可以看出  
左 < 中 或 左 > 中 時，都有可能要往右找，  
而 
- 中 < 右，右半是有序的，要往左找
- 中 > 右，左半是有序的，往右找

直接比較 中 和 右 即可

然後嘗試推導，試試迴圈終止條件和給值條件是否要調整

這題我們無法直接判斷 nums[middle] 是不是最小值  
那就先試試沿用  
當 nums[middle] < nums[right] => 令 right = middle - 1  
當 nums[middle] > nums[right] => 令 left = middle + 1  
會推出錯誤的結果

例: [4, 5, 1, 2, 3]  
left = 0, right = 4  
middle = (0 + 4) / 2 = 2  
list[middle] = 1 <= list[right] = 3  
right = middle - 1 = 1

left = 0, right = 1  
middle = (0 + 1) / 2 = 0  
list[middle] = 4 <= list[right] = 5  
right = middle - 1 = -1

可以看到離答案越來越遠  
觀察後發現給值方式需要調整，  

當 nums[middle] <= nums[right]  
代表 middle <= i <= right 這右半邊是有序的，最小值不會出現在右半邊。但也無法排除 nums[middle] 就是最小值的可能性，所以要讓 right = middle  

當 nums[middle] > nums[right]  
代表 left <= i <= middle 這左半邊是有序的，最小值也不會出現在左半邊，也可以排除 nums[middle] 是最小值的可能性，因為已有 nums[middle] > nums[right]，所以要讓 left = middle + 1  

那麼就給值條件就改為
- 當 nums[middle] <= nums[right]，right = middle
- 當 nums[middle] > nums[right]，left = middle + 1

如果迴圈條件仍用 left <= right，會發現當 left = right 時，會進入無窮迴圈，所以也改成 left < right

再來試著推導

例: [4, 5, 1, 2, 3]  
left = 0, right = 4  
middle = (0 + 4) / 2 = 2  
list[middle] = 1 <= list[right] = 3  
right = middle = 2

left = 0, right = 2  
middle = (0 + 2) / 2 = 1  
list[middle] = 5 > list[right] = 1  
left = middle + 1 = 2

不滿足 left < right，達到終止條件  
且 left 指向最小數字的 index  
回傳 left  

嘗試推導  
[5, 1, 2, 3, 4]  
[4, 5, 1, 2, 3]  
[3, 4, 5, 1, 2]  
[2, 3, 4, 5, 1]  
left 最終都會指向數字最小的 index

### 複雜度

#### Time: O(log(n))

#### Space: O(1)