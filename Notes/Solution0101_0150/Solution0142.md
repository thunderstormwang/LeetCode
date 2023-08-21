# Solution0142 Linked List Cycle II

## Ver1 - Math

這題得用數學來解，用 Floyd Cycle Detection Algorithm  

開頭跟 [Solution0141](Solution0141.md) 一樣使用兩個指針 slow, fast，如果兩者會合，代表有 cycle。  
然後讓 slow 保持在原點, 再讓 fast 回到 head，這次 slow, fast 同時各走一個節點, 最終會在入口處會合。

數學根據就不寫在這裡了。

### 複雜度
- 節點數目: n

#### Time: O(n)

#### Space: O(1)