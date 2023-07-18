# Solution0739

我喜歡這題, 很容易就想到暴力法怎麼解, 然後再去想該怎麼優化

## Ver1 - 暴力法

暴力法很容易想，很意外沒超時  

第 0 個元素最多要往右看 n-1 個元素  
第 1 個元素最多要往右看 n-2 個元素  
...  
第 n-1 個元素最多要往右看 1 個元素  

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Memory: O(1)

---

## Ver2 - Monotonic Stack - 單調棧

又是一題證明 LeetCode 順序很爛的例子，這題應該比
- [Solution0084](../Solution0051_0100/Solution0084.md)
- [Solution0042](../Solution0001_0050/Solution0042.md)

還前面才是

使用 Stack，儲存 index，越往頂端，temperatures<sub>i</sub> 則越高，形成遞減形式的單調棧  

遍歷 temperatures，假設當前 index 為 i，且假定 Stack 的頂端元素是 curr
- 如果 temperatures[i] <= temperatures[curr]
  - stack.Push(i)
- 如果 temperatures[i] > temperatures[curr]，代表 curr 找到下一個溫度比它高的日子
  - curr = stack.Pop();
  - 計算 i 離 curr 有多少日子
  - 更新 curr
  - 重覆上述過程直到 temperatures[i] <= temperatures[curr] 或是 stack 沒有元素為止
  - Stack.Push(i) 

遍歷完 heights，仍需將 stack 清空，流程與上述相同，但這些剩下的元素都找不到下一個溫度比它高的日子

### 複雜度

#### Time: O(n)
- 寫出來會發現很多層迴圈，不過 height 每個元素只會被放入 stack 一次，且取出時它離下一個溫度較高的天數，所以是 n 次運算: O(n)

#### Memory: O(n)
- Stack 最多儲的元素: O(n)