# Solution0739

## 暴力法

暴力法很容易想，很意外沒超時  

第 0 個元素最多要往右看 n-1 個元素  
第 1 個元素最多要往右看 n-2 個元素  
...  
第 n-1 個元素最多要往右看 1 個元素  

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Memory: O(1)

---

## Stack

想出暴力法後，直覺認為有 O(n) 的解法，不過沒想到...

建立 Stack，儲存 index

跑迴圈，每個 temperatures<sub>i</sub> 做跟 Stack 的第一個元素比較
- temperatures<sub>i</sub> <= temperatures<sub>top</sub>，將 i 也 push 進 stack，然後看下一個 i
- temperatures<sub>i</sub> > temperatures<sub>top</sub>
  - 跑迴圈，逐一取出 Stack 的第一個元素，只要 temperatures<sub>i</sub> > temperatures<sub>top</sub>，temperatures<sub>top</sub> 就找到比它大的下一個溫度，index 距離為 i - top
  - temperatures<sub>i</sub> <= temperatures<sub>top</sub>，將 i 也 push 進 stack，然後看下一個 i

### 複雜度

#### Time: O(n)

#### Memory: O(n)