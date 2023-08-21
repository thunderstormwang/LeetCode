# Solution0191 Number of 1 Bits

## Ver1 - Bit Manipulation

用 shift operator，  
n 和 1 做 AND 運算並加總結果後，將 n 往右 shift 一位

### 複雜度

#### Time: O(1)
- 因為 n 是 32 位元，所以最多只會有 32 個位數，所以 log(n) = 32: O(1)

#### Memory: O(1)

---

## Ver2 - Bit Manipulation

用 mod operator，  
n mod 2 後並加總結果後，將 n 除以 2

### 複雜度

#### Time: O(n)
- 因為 n 是 32 位元，所以最多只會有 32 個位數，所以 log(n) = 32: O(1)

#### Memory: O(1)

---

## Ver3 - Bit Manipulation

n AND (n - 1) 會將 n 最右邊的 1 變成 0  
計算做幾次就是有幾個 1

### 複雜度

#### Time: O(n)
- 因為 n 是 32 位元，所以最多只會有 32 個位數，所以 log(n) = 32: O(1)

#### Memory: O(1)