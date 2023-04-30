# Solution0015

## 暴力法

跑三個迴圈

### 複雜度

#### Time: O(n<sup>3</sup>)

#### Space: O(1)

---

## Two Pointer

因為暴力法的複雜度是 O(n<sup>3</sup>)，那就可以考慮先做排序  
再輪詢每個元素，再用兩個指標，分別從該次元素的下一個位置(left), 和從陣列尾端(right)
- 如果三者的和等於 target，將 left 重覆加 1 和 right 重覆減 1 直到遇到新的數字
- 如果三者的和比 target 較小, 將 left + 1
- 如果三者的和比 target 較大, 將 right - 1

### 複雜度

#### Time: O(n<sup>2</sup>)
- 排序: O(n * log(n))  
- 輪詢每個元素: O(n<sup>2</sup>)  

相加後取最大項:  O(n<sup>2</sup>)

#### Space: O(1)