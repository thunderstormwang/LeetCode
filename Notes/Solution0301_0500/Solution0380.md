# Solution0380 Insert Delete GetRandom O(1)

## List 和 Dictionary

C# 似乎不適合這題，List.RemoveAt 查 MSDN 是 O(n)  
在當場寫白板題時，也很難把 Random 函式寫對  

因為題目要求 GetRadndom 也要 O(1)，那只用 HashSet 或 Dictionary 是無法達成的  
需要 List 和 Dictionary 一起使用，也就是空間換取時間

Insert  
同時在 list 和 dict 增加元素，用 dict 儲在元素在 list 的位置  

Remove  
dict 找回目標元素在 list 的位置，將它與 list 最後一個元素交換，然後在 list 和 dict 刪除目標元素  

GetRandom  
依亂數生成的位置在 list 取得元素  

### 複雜度

#### Time: O()
- Insert: O(1)
- Remove: O(1) -- ?
- GetRandom: O(1)

#### Space: O(n)
- list: O(n)
- dict: O(n)