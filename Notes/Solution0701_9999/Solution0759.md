# Solution0759 Employee Free Time

## 排序

雖然是 hard，但挺容易想的  

先攤平同一個 List 內  
依左邊界再依右邊界排序後  
再輪詢陣列，只要當前區間的起始有大於前一個區間的終點，即代表出現一個大家都有空的區間

### 複雜度

#### Time: O(n * long(n))
攤平 -- O(n)  
排序 -- O(n * long(n))  
輪詢找空閒區間 -- O(n)  

#### Space: O(n)