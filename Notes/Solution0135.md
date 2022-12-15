# Solution0134

這題好難...真的難

我的想法是起始糖果數量為 1，然後由左往右，
- rating[i] > rating[i-1]，i 的糖果要比 i-1 多 1，
- rating[i] < rating[i-1]，i 的糖果要比 i-1 少 1
- rating[i] = rating[i-1]，i 的糖果從 1 開始算

在過程中如果遇到波峰，要將位置記錄下來，而且下一個位置的糖果從 1 開始給。

還到波谷後，確認現在該發的糖果為負數，那從上個波峰到現在波谷的糖果的數量都往上平移

這想得挺複雜的，也難想寫出來...

Candy_Greedy01

Time: O(N)

Memory: O(N)

Candy_Greedy02

Time: O(N)

Memory: O(N)