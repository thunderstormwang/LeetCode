# Solution0362 Design Hit Counter

## Ver1 - Queue

一開始誤以為這題屬於 stack，但只想到是用 linked list 去做到先進先出的效果。  
就一直沒動手，原來這題是 queue。

運用先進先出的機制，Hit 放元素，在 GetHit 先把太舊的 timestamp 給移除再計算 queue 的元素數目

### 複雜度

#### Time: O(n)
- 可能需要一次從 queue 移除 n 個元素: O(n)

#### Space: O(n)
- queue 可能存 n 個元素: O(n)

---

## Ver2 - Array

用兩個陣列，timestamps 儲存 timestamp，couter 用來計數

Hit
- 當 timestamps[timestamp % 300] 等於 timestamp，couter[timestamp % 300] 加 1  
- 當 timestamps[timestamp % 300] 不等於 timestamp，代表已過 300 秒，更新 timestamps[timestamp % 300] = timestamp ，且 coutertimestamp % 300] 設為 1

GetHit  
- 當 timestamp - timestamps[] < 300 才將 couter[i] 列入計算 

### 複雜度

#### Time: O(1)
- 陣列長度固定，就不影嚮 Hit 和 GetHit 的時間: O(1)

#### Space: O(1)
- 陣列長度固定: O(1)