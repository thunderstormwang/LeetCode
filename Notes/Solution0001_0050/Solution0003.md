# Solution0003

## 暴力法

在 index 0 最多可能要往右找 n-1 的字元  
...  
在 index n-1 最多可能要往右找 1 的字元

### 複雜度

#### Time: O(n<sup>2</sup>)

#### Space: O(n)
- 每次看一子字串，需要一個 HashSet 儲存已存在的字元: O(n)

---

## SlideWindow Ver1

抄 LeetCode 的官方解答

### 複雜度

#### Time: O(n)
- 最差情況下, 該字串都是同個字元, 會被 i, j 各走一次: O(2n) = O(n)  

#### Space: O(Min(size of string, size of charset))

---

## SlideWindow Ver2

抄 LeetCode 的官方解答，真簡潔...

### 複雜度

#### Time: O(n)

#### Space: O(Min(size of string, size of charset))

---

## SlideWindow Ver3

我自己想的，卡很久...  

一開始想說用個 Dictionary 儲存每個走過的字元的 index  
輪詢陣列
- 如果 s[i] 沒出現在 Dictionary
  - 當前長度 length ++
  - 更新 Dictionary[s[i]] 為 i
  - 判斷 lenth 是否為目前走過的最大長度
- else
  - 將當前長度縮減為 length = i dict[s[i]]
  - 更新 Dictionary[s[i]] 為 i

這想法是對的，只是沒考慮到已出現在 Dictionary 的字元也可能已過時  
例如: tmmzuxt  
走到第二個 m 時，Dictionary['t'] 也已失效  
所以需要記錄子字串的起始位置

初始化 Dictionary  
初始化 left = -1 
輪詢陣列
- 如果 s[i] 沒出現在 Dictionary 或是 Dictionary[s[i]] 小於 left
  - 字串長度繼續延申
  - 當前長度 length++
  - 更新 Dictionary[s[i]] 為 i
  - 判斷 lenth 是否為目前走過的最大長度
- else
  - 子串長度需縮短，改從 dict[s[i]]+1 開始計算
  - 將當前長度縮減為 length = i - dict[s[i]]
  - 更新字串起始位置，left 為 dict[s[i]] + 1
  - 將 dict[s[i]] 更新為 i

### 複雜度

#### Time: O(n)

#### Space: O(Min(size of string, size of charset))