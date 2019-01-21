// 44ms, 100%, 5m, 2t
public class Solution {
    public int Fib(int N) {
        int a = 0, b = 1;
        if (N == 0) return a;

        int f = 0;
        for (int i = 2; i <= N; ++i)
        {
            b += a;
            a = b - a;
        }
        return b;
    }
}