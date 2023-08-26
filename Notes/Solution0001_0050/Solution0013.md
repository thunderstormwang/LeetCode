# Solution0013 Roman to Integer

## Ver1 - Math

用 Dictionary，除了列出每個字母代表的數字以外，  
也用 HashSet 記錄每個例外情況：IV, IX, XL, XC, CD, CM

遍歷字串 s，
如果 s[i]~s[i+1] 不在 HashSet 中，則直接加上 dict[s[i]]  
反之則加上 -1 * dict[s[i]]

### 複雜度

#### Time: O(1)
- s 最長為 15 個字元，所以最多只會跑 15 次迴圈: O(1)

#### Space: O(1)

---

## Ver2 - Math

公認的解答中，並不需要用 HashSet 來記錄例外情況，比起 Ver1 來說，更好地 generalize 出所有情況。

因為題目也說明了羅馬數字都是由大到小排列列的，如果出現左邊的數字比右邊的小，就代表左邊的數字要減掉。

遍歷字串 s，
如果 dict[s[i]] < dict[s[i+1]]，則加上 -1 * dict[s[i]]，  
反之則加上 dict[s[i]]

### 複雜度

#### Time: O(1)
- s 最長為 15 個字元，所以最多只會跑 15 次迴圈: O(1)

#### Space: O(1)