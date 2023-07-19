# Solution0844 Backspace String Compare

## Ver1 - Stack

簡單題，用 stack 儲存遍歷的字元，  
當遇到 '#' 就取出 stack 元素，若 stack 為空就跳過  
最後比較兩個 stack 的字元

### 複雜度
- s 的長度: n
- t 的長度: m

#### Time: O(n + m)
- 遍歷 s: O(n)
- 遍歷 t: O(m)
- 比較字串: O(Min(n, m))

相加後取最大: O(n + m)

#### Memory: O(n + m)
- stack1 的空間: O(n)
- stack2 的空間: O(m)

相加後取最大: O(n + m)

---

## Ver2

要求使用空間 O(1)，難度上升變為 medium，且容易出錯  

用兩個指針 pointer1, pointer2，分別從 s, t 的最後面開始  
在 s[pointer1] = '#'或 '#' 的累計數目仍大於 0 時，都要持續倒退  
在 t[pointer2] = '#'或 '#' 的累計數目仍大於 0 時，都要持續倒退  
然後比較 s[pointer1] 跟 t[pointer2] 是否相等  

如果走到 pointer1 = pointer2 = -1，那代表 s, t 的最終結果相等

#### Time: O(n + m)

雖然是雙重迴圈，不過其實是個別遍歷字串 s 和 t

- 遍歷 s: O(n)
- 遍歷 t: O(m)

相加後取最大: O(n + m)

#### Memory: O(1)