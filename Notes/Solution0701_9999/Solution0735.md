# Solution0735 Asteroid Collision

## Ver1 - Stack

用 stack 儲存隔殞石，但在 asteroids[i] < 0 時得小心判斷 asteroids[i] 是否也爆炸或是該放入 stack

遍歷 asteroids
- 當 asteroids[i] > 0
  - stack.Push(asteroids[i])
- 當 asteroids[i] < 0
  - 當 stack.Peek() 為正且 <= asteroids[i]
  - stack.Pop()
  - 如果 asteroids[i] 還沒爆炸，也放入 stack

最後留在 stack 的元素轉成陣列再反轉，即是答案

### 複雜度

#### Time: O(n)
- 遍歷 asteroids 所有元素: O(n)
- 反轉陣列: O(n)

#### Memory: O(n)
stack 最多存 n 個元素: O(n)

---

## Ver2 - List

看其它人的解答，在 C++ 用 vector\<int> 來做  
不過 C# 的 List.RemoveAt 是 O(n)，應該沒有比較快

### 複雜度

#### Time: O(n)
- 遍歷 asteroids 所有元素: O(n)
- List.RemoveAt: O(n)

#### Memory: O(n)
