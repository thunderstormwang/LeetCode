# Solution0190 Reverse Bits

## Ver1 - Math

把它當作 10 進位一樣的處理

```csharp
result = result * 2 + n % 2;
n /= 2;
```

### 複雜度

#### Time: O(1)
- 因為 n 是 32 位元，所以最多只會有 32 個位數，所以 log(n) = 32: O(1)

#### Memory: O(1)

---

## Ver2 - Bit Manipulation

改用位移的方式

```csharp
result = (result << 1) + (n & 1);
n >>= 1;
```

### 複雜度

#### Time: O(1)
- 因為 n 是 32 位元，所以最多只會有 32 個位數，所以 log(n) = 32: O(1)

#### Memory: O(1)