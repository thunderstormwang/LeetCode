# Solution0287 Find the Duplicate Number

## Ver1 - Bit Manipulation

nums 長度為 n + 1，且數字範圍為 1 到 n，可以計算每個位元出現的 1 的次數的差異
令 bitCount 代表位元的位置，0 <= bitCount < 32  

令 count1 為 1 到 n 在 bitCount 位元出現 1 的次數。  
令 count2 為 nums[0] 到 nums[n] 在 bitCount 位元出現 1 的次數。  
如果 count2 > count1，則代表重複的數字在 bitCount 位元有重覆出現，需要記錄下來。

重覆上述步驟 32 次，就可以得到重複的數字。

### 複雜度

#### Time: O(n)
- 一共有 32 個位元，且有 n 個數字，所以要做 32 * n 個運算: O(n)

#### Space: O(1)

---

## Ver2 - Binary Search

初始令 left = 0，right = nums.Length。

計算 nums 中小於等於 middle 的元素數目 count，  
如果 count <= middle，代表重複的數字在 middle 的右邊，那就讓 left = middle + 1。  
如果 count > middle，代表重複的數字在 middle 的左邊，那就讓 right = middle。

重覆上述步驟直到 left >= right，則 right 就是重複的數字。

### 複雜度

#### Time: O(n * log(n))
- binary search 一共是 log(n)，然後每次都要遍歷 nums 計算 count，所以是 O(n * log(n))

#### Space: O(1)

---

## Ver3 - Linked List Cycle

把陣列當作 Linked List，每個元素的值代表下一個節點的 index，例如 nums[0] = 3，代表 index 0 的下一個節點是 index 3。因為有重覆的元素，代表一定會有 cycle，所以可以用 [Solution0142](../Solution0101_0150/Solution0142.md) 的方法來解。  

這方法我疑惑很久，為什麼可以這樣算，一直在想會不會有種情形是有多個 nums[i] = i，然後在還沒走到 cycle 時就走到 nums[i] 導致走不出來??  
但實際上這情形不會發生，因為如果在 nums[i] = i 的情況下又走到 i，就代表有兩個 index 指向同一個節點，那就有 cycle 產生了。

### 複雜度

#### Time: O(n)

#### Space: O(1)
