public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> rDict = new Dictionary<char, int>();
        foreach (char c in ransomNote)
        {
            if (rDict.ContainsKey(c))
            {
                rDict[c]++;
            }
            else
            {
                rDict.Add(c, 1);
            }
        }
        foreach (char c in magazine)
        {
            if (rDict.ContainsKey(c))
            {
                rDict[c]--;
            }
        }
        foreach (var value in rDict.Values)
        {
            if(value > 0)
            {
                return false;
            }
        }
        
        return true;
    }
}