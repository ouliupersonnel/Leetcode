// 108ms, 78.37%, 5m, 1t
public class Solution
{
    public int UniqueMorseRepresentations(string[] words)
    {
        string[] morse = new string[] {
            ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."
        };

        HashSet<string> rep = new HashSet<string>();
        foreach (var word in words)
        {
            string s = "";
            foreach (var c in word)
                s += morse[c - 'a'];
            rep.Add(s);
        }

        return rep.Count();
    }
}