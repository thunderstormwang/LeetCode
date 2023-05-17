# Solution0033

## Binary Search

二分法的變型，主要還是找出怎麼切半的方法

找出有序的那半段，檢查 target 是否在有序的那半，若否就是在另一個半段  
於是就知道該留下哪個半段了

### 複雜度

#### Time: O(log(n))

#### Space: O(1)