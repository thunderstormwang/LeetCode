# Solution0424 Longest Repeating Character Replacement

## Sliding Window

好難...沒看過解答我連絕對想不出來，連 generalize 手動的方式都有困難

假設字串中出現最多次的字母的次數為 max，而我們可容許替換字元 k 次  
那麼維持一個可變長度的 Sliding Window  
max 為出現同個字母出現最多次的次數
left 為左指針，right 為右指針  

- 當 right - left + 1 > max + k
  - 可替換的次數已用光，將 Window 縮短，left++
- 當 right - left + 1 <= max + k
  - 可替換的次數還有剩，將 Window 變長，right++

最後 s.Length - left 即是答案

### 複雜度

#### Time: O(n)

#### Memory: O(1)