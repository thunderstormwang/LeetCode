# Solution0076

## 暴力法

在 index 0 最多可能要往右找 n-1 的字元  
...  
在 index n-1 最多可能要往右找 1 的字元

### 複雜度

#### Time: O(n<sup>2</sup>)
- n 為字串 s 的長度

#### Space: O(m)
- m 為字串 t 的長度

---

## Ver1 - Sliding Window + Two Pointer

好難...，generalize 不出規則來，的確是 hard

運用可變大小的 Sliding Window，找出最小的範圍。  
利用雙指針，left 和 right 都從 0 出發，  
right 往右擴充，直到符合要求，  
再換 left 往右縮減，並持續更新最小範圍，直到不符合要求    
重覆上述過程直到 right 遍歷完字串 array

例如以下例子: ADOBECODEBANC

往右擴充，找到 ADOBEC，符合要求，判斷長度決定是否記錄現在長度和起始位置  
從左邊縮減，DOBEC，不符要求  
往右擴充...  
往右擴充，DOBECODEBA，符合要求，判斷長度決定是否記錄現在長度和起始位置  
從左邊縮減...  
從左邊縮減，CODEBA，符合要求，判斷長度決定是否記錄現在長度和起始位置  
從左邊縮減，ODEBA，不符要求  
往右擴充...  
往右擴充，ODEBANC，符合要求，判斷長度決定是否記錄現在長度和起始位置  
從左邊縮減...  
從左邊縮減，BANC，符合要求，判斷長度決定是否記錄現在長度和起始位置  

最後回傳最小的答案

看得懂想法，寫出程式碼又是另一回事...

### 複雜度

#### Time: O(n + m)
- n 為字串 s 的長度
- m 為字串 t 的長度

#### Space: O(m)
- m 為字串 t 的長度

---

## Ver2 - Sliding Window + Two Pointer

同 Ver1，只是換了迴圈的寫法

### 複雜度

#### Time: O(n + m)
- n 為字串 s 的長度
- m 為字串 t 的長度

#### Space: O(m)
- m 為字串 t 的長度