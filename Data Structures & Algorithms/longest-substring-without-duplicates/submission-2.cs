public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int longestLength = 0, left = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for(int right = 0; right < s.Length; right++) {
            char curChar = s[right];
            if(dict.ContainsKey(curChar) && dict[curChar] >= left) {
                left = dict[curChar] + 1;
            }
            dict[curChar] = right;
            longestLength = Math.Max(longestLength, right - left + 1);
        }
        return longestLength;
    }
}
