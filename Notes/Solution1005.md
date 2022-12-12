# Solution1005

0 次轉正負號: sum<sub>0</sub>
<br/> 1 次轉正負號: sum<sub>0</sub> + 最小值轉換正負號

...

k-1 次轉正負號: sum<sub>k-2</sub> + 最小值轉換正負號
<br/>k 次轉正負號: sum<sub>k-1</sub> + 最小值轉換正負號

在不做排序的情況，每次找最小值要花掉 O(N)，所以總共是 O(K * N)

可想而知要對 nums 做排序，將複雜度降為 N * log(N)，最後要考慮到當 nums 都轉為正數後, k 的次數仍有剩的情況。

不過我沒想到可以對 nums 做絕對值的排序，增加排序的程式碼，但簡化當 k 的次數仍有剩的程式碼。

Time: O(N * log(N))
<br/>O(N * log(N)) + Min(O(N), O(k))，只留最大項

Memory: O(1)