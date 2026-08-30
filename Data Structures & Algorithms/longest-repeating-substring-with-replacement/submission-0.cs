public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        int left = 0;
        int longestSubStr = 0;
        for(int right = 0; right < s.Length; right++) {
            char currentChar = s[right];
            freq[currentChar] = freq.GetValueOrDefault(currentChar, 0) + 1;
            int windowLength = right - left + 1;
            int maxFrequency = freq.Values.Max();
            while(windowLength - maxFrequency > k) {
                freq[s[left]]--;
                left++;

                windowLength = right - left + 1;
                maxFrequency = freq.Values.Max();
            }
            longestSubStr = Math.Max(longestSubStr, windowLength);
        }
        return longestSubStr;
    }
}
