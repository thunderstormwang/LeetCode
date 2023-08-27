# Solution0310 Minimum Height Trees

好難, 不像 medium 呀

## Breadth First Search

第一個想到的解法

建立鄰接表，為雙向，節點<sub>A</sub> 可以到 節點<sub>B</sub>，節點<sub>B</sub> 可以到 節點<sub>A</sub>  
建立陣列 visited 記錄每個節點是否已拜訪過

輪詢每個節點，用 BFS 探索每個節點，將一層的節點探索完後，若 queue 中還有新元素，就表示高度加 1

但是這做法會 TLE，即使將目前所有節點計算到的最低高度記起來，其它節點只要在清空 queue 的過程中超過最低高度就放棄，仍然會 TLE

### 複雜度

#### Time: O(n<sup>2</sup>)
- 建立鄰接表: O(n)
- 輪詢每個節點，且每次輪詢過程每個節點都會被放入 queue 一次: O(n<sup>2</sup>)

#### Memory: O(n)
- 鄰接表最多放 2n: O(n)
- queue 最多放 n: O(n)

---

## 類似拓撲排序

Todo: 畫圖解釋  
用剝洋蔥的方式，逐一去除不可能的節點，直到剩餘的節點數 <= 2

建立鄰接表後，將鄰接數只有 1 的節點放入 queue。
輪詢 queue
- 取出 queue 的節點<sub>i</sub>
- 從鄰接表中取所有與節點<sub>i</sub> 相鄰的節點<sub>j</sub>
- 從鄰接表去除所有節點<sub>j</sub> 與 節點<sub>i</sub> 的連接，如果這導致某個 節點<sub>j</sub> 的鄰接數也剩 1，那就放入 queue

重覆此過程，直到剩餘沒拜訪過的節點數 <= 2，這些節點將能組出最低高度

### 複雜度

#### Time: O(n)
- 建立鄰接表: O(n)
- 每個節點都會被放入 queue 一次: O(n)

#### Memory: O(n)
- 鄰接表最多放 2n: O(n)
- queue 最多放 n: O(n)