# Solution0004 Median of Two Sorted Arrays

## Binary Search

超難...解答也看了好一陣子才懂..

中位數是位於中間的數字  
若長度是奇數，就是第 (n / 2) + 1 個的數字  
若長度是偶數，就是第 (n / 2) + 1 和 第 (n / 2) + 2 個數字之和的平均

這裡可以用點技巧  
(n + 1) / 2 和 (n + 2) / 2  
兩者在奇數會算出一樣的數字，正中間的數字  
兩者在偶數會算出不一樣的數字，正中間的兩個數字  

令
n1 = nums1 的長度  
n2 = nums2 的長度  
k = (n1 + n2 + 1) / 2，也就代表前半段的數字  

再假設這 k 個數字是由  
nums1 取出前 m1 個數字  
nums2 取出前 m2 個數字  
所組成

也就是第 k 個數字是 Math.Max(nums1[m1-1], nums2[m2-1])  
而第 k+1 個數字是 Math.Min(nums1[m1], nums2[m2])

nums[m1] 一定大於 nums2[m2-1]，也就找到切半的方法

這裡跟其它 Binaray Search 不一樣的地方是，我們用取幾個數來當作 left 和 right 的值(想改用 index 套進去會發現很難做)  
我們也無法直接判斷是否 nums1[middle] 就是我們要的值而離開迴圈  
當 nums[m1] < nums2[m2-1] 可以很肯定 m1 不是我們要找的，所以 left = m1 + 1  
當 nums[m1] >= nums2[m2-1] 無法排除 m1 不是我們要找的，所以 right = m1  
然後可以發現當 left = right，會算出相同的 m1 和 m2 就進入無窮迴圈，所以迴圈終止條件設為 left < right  

理論就到這裡，實際上還有許多眉眉角角  
例如 從較短的陣列 nums1 切半去找，就不用考另一個陣列在 nums2[m2] 是否超出範圍  
最後找第 k 和 k+1 個數字時，要考慮 m1 和 m2 是否超出陣列範圍

### 複雜度

#### Time: O(log(n+m))
- n: nums1 的長度
- m: nums2 的長度

#### Space: O(1)