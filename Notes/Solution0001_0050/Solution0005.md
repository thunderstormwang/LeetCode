# Solution0005

## 暴力法

在 index 0 有 n 個可能字串  
...  
在 index n-1 有 1 個可能字串  

### 複雜度

#### Time: O(n<sup>3</sup>)
- 一共有 n(n-1)/2 個子字串, 每個子字串比較需要 O(n)

#### Space: O(1)

---

## Dynamic Programming

忘了怎麼做了...  

判斷 s[i]~s[j] 是不是 palindrome 可以拆解成
- s[i+1]~s[j-1] 是不是 palindrome
- s[i] == s[j]

所以需要一個 dp 記錄 s[i+1]~s[j-1] 是否為 palindrome 字串，供後續使用

dp 初始值
- dp[i][i] 為 true
- 若 s[i]~s[i]+1 為 palindrome，dp[i][i+1] 為 true

### 複雜度

#### Time: O(n<sup>2</sup>)
迴圈從長度 = 3 開始跑，有 n - 3 個子字串  
...  
長度 = n，有 1 個子字串  
加總起來是 O(n<sup>2</sup>)

#### Time: O(n<sup>2</sup>)