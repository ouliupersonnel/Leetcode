// 60ms, 45.08%, 3m, 1t
public class Solution {
    public int Fib(int N) {        
        int a = 0, b = 1;
        if (N == 0) return a;
        if (N == 1) return b;
        
        int f = 0;
        for (int i = 2; i <= N; ++i){
            f = a + b;
            a = b;
            b = f;
        }
        return f;
    }
}