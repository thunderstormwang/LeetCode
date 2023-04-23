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

## SlideWindow + Two Pointer

好難...的確是 hard

ADOBECODEBANC

往右擴充，找到 A，不符要求  
往右擴充...  
往右擴充，找到 ADOBEC，符合要求  
從左邊縮減，DOBEC，不符要求  
往右擴充...  
往右擴充，DOBECODEBA，符合要求  
從左邊縮減...  
從左邊縮減，CODEBA，符合要求  
從左邊縮減，ODEBA，不符要求  
往右擴充...  
往右擴充，ODEBANC，符合要求  
從左邊縮減...  
從左邊縮減，BANC，符合要求  

看得懂想法，寫出程式碼又是另一回事...

### 複雜度

#### Time: O(n + m)
- n 為字串 s 的長度
- m 為字串 t 的長度

#### Space: O(m)
- m 為字串 t 的長度