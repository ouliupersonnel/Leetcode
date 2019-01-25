// 360ms, 41.12%, 5m, 1t
public class Solution {
    public int DistributeCandies(int[] candies) {
        HashSet<int> kinds = new HashSet<int>();
        foreach(int c in candies)
            kinds.Add(c);
        int maxKind = candies.Length / 2;
        return kinds.Count >= maxKind ? maxKind : kinds.Count;
    }
}