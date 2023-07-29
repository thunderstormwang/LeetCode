# Solution0895 Maximum Frequency Stack

## Hash Table

用 Dictionary _numberFreqMapping 記錄數字與出現次數的對應  
用 Dictionary _freqNumberMapping 記錄出現次數與數字的對應  
用 _maxFreq 記錄最高的出現次數

Push
- 更新該數字在 _numberFreqMapping 的出現次數
- 如果需要，就更新 _maxFreq
- 更新 _freqNumberMapping

Pop
- 更新 _freqNumberMapping
- 如果需要，就更新 _maxFreq
- 更新該數字在 _numberFreqMapping 的出現次數

### 複雜度

#### Time: O() --?

#### Space: O() --?