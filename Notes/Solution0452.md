# Solution0452

這題容易想出解法，不過我還是卡在怎麼找重疊的氣球上...一直往複雜的方向去想。

看了解答才恍然大悟，原來可以這麼解，

將當前氣球的右邊邊界修改為 Min(前一個氣球的右邊邊界, 當前氣球的右邊邊界) 就解決重疊的問題了

Time: O(N* log(N) ) --
- 排序: O(N* log(N) )
- 走完陣列: O(N)

相加後取最大項

Memory: O(1)