# Solution0704

## Binary Search

基本題，遵照

```csharp
var left = 0;
var right = array.Length - 1;
while(left <= right)
{
    var middle = (left + right) / 2;
    if(array[middle] == target)
    {
        return array[middle];
    }

    if(array[middle > target])
    {
        left = middle + 1;
    }

    right = middle - 1;
}
```

## Iteratvie

### 複雜度

#### Time: O(log(n))

#### Space: O(1)

---

## Recursive

### 複雜度

#### Time: O(log(n))

#### Space: O(1)