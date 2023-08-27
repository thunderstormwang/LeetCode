# Solution0146 LRU Cache

一開始想用 linked list 和 Dictionary 去做  
發現很難...  
在推導到如何將節點移到最前面時會無法用 O(1) 做到  
其實這時候就該知道得用其它資料結構了

## Ver1 - doubly linked list

自己做資料結構，每個節點可指到前一個和下一個節點

在 Get 時，如果節點存在，要將它移到最前面

在 Put 時，  
如果節點存在，更新節點的值並將它移到最前面  
如果節點不存在，新增節點並將它放到最前面，如果數量超過就需要移除最後一個節點  

### 複雜度

#### Time: O(1)

#### Space: O(n)

---

## Ver2 - doubly linked list

如果是 C++，有提供內建的 double linked list  
C# 可以用 linked list

### 複雜度

#### Time: O(1)

#### Space: O(n)