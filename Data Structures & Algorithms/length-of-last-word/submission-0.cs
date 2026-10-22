public class Solution {
    public int LengthOfLastWord(string s) {
        string[] arrS = s.Trim().Split();
        if(arrS.Length == 0) return 0;
        int lastWordLength = arrS[arrS.Length - 1].Length;
        return lastWordLength;
    }
}