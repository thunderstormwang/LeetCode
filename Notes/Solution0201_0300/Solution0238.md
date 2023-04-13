# Solution0238

被這題難住了，用 two pointer、circular 的複雜度都跟暴力法一樣，就想不到解法，掙札了幾下就看解答了

## 暴力法

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(1)

---

## Ver1

建立兩個陣列  
left[i] 為 nums[0]~nums[i-1] 的乘積  
right[i] 為 nums[i+1]~nums[n-1] 的乘積  
所以 result[i] = left[i] * right[i]

### 複雜度

#### Time: O(n)

#### Space: O(n)

---

## Ver2

承自 Ver1
只用一個陣列  
先由左往右跑，讓陣列 result 就等於 Ver1 的陣列 left  
再由右往左跑，用一個暫時變數儲存累積的乘積
```csharp
result[i] *= right;
right *= nums[i];
```
### 複雜度

#### Time: O(n)

#### Space: O(1)