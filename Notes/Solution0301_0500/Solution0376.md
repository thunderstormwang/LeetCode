﻿# Solution0376

這題卡好久...

碰壁了幾次才發現沒看清楚題目, 

一、可以刪除元素，意思就是我們可以在波峰的路段上一直刪元素，直到開始遇到波谷
例: 輸入 {1, 2, 3, 4, 5, 1} 就是刪到剩 {1, 2, 1} 或是剩 {1, 5, 1}, 答案都是 2
反之若現在往波谷的路上, 就是一直刪元素直到開始遇到波鋒

二、還有另一點我沒從題目看出來的是輸入 {2 ,2} 答案是 1,輸入 {2 ,2, 2} 答案也是 1, 

綜合以上幾點，演算法如下：

#### 貪心解法

當陣列長度 <= 1, 輸出陣列長度

當陣列長度 >= 2,
1.  設定 result 起始值為 1, preDiff 起始為 0
2.  從 index = 1 開始跑迴圈
    1. currDiff 為當前元素減去前個元素
    2. 當 currDiff, preDiff 為同正負號, 代表同為波鋒或波谷, 不增加 result 以摸擬刪去元素
    3. 當 currDiff, preDiff 為不同正負號, 代表遇到轉折, result 可以 + 1
    4. 然後將 currDiff 指派給 preDiff
    5. 再開始下一輸迴圈

最後回傳 result 

Time: O(N)

Memory: O(1)

動態規劃: 待補...

