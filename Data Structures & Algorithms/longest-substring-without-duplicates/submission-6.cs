public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;
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
        // if(s.Length == 0) return 0;
        // if(s.Length == 1) return 1;
        // HashSet<char> subStr = new HashSet<char>();
        // int maxLength = 0;
        // int left = 0;
        // for(int right = 0; right < s.Length; right++){
        //     while(subStr.Contains(s[right])){
        //         subStr.Remove(s[left]);
        //         left++;
        //     }
        //     subStr.Add(s[right]);
        //     maxLength = Math.Max(right - left + 1, maxLength);
        // }
        // return maxLength;
    }
}
