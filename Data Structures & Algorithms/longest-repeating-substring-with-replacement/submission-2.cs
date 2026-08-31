public class Solution {
    public int CharacterReplacement(string s, int k) {
        // Dictionary<char, int> freq = new Dictionary<char, int>();
        int[] freq = new int[26];
        int longestSubStr = 0;
        int left = 0;
        int maxFrequencyValue = 0;
        int windowLength = 0;
        
        for(int right = 0; right < s.Length; right++){
            freq[s[right] - 'A']++;
            maxFrequencyValue = Math.Max(maxFrequencyValue, freq[s[right] - 'A']);
            windowLength = right - left + 1;

            while(windowLength - maxFrequencyValue > k) {
                freq[s[left] - 'A']--;
                left++;
                windowLength = right - left + 1;
            }


            // char currentChar = s[right];
            // freq[currentChar] = freq.GetValueOrDefault(currentChar, 0) + 1;
            // maxFrequencyValue = freq.Values.Max();
            // windowLength = right - left + 1;

            // while(windowLength - maxFrequencyValue > k) {
            //     freq[s[left]]--;
            //     left++;
            //     maxFrequencyValue = freq.Values.Max();
            //     windowLength = right - left + 1;
            // }

            longestSubStr = Math.Max(longestSubStr, windowLength);
        }
        return longestSubStr;
    }
}
