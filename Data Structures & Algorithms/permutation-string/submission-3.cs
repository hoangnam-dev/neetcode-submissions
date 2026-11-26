public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;
        int[] freq = new int[26];
        int[] windownFreq = new int[26];
        for(int i = 0; i < s1.Length; i++) {
            freq[s1[i] - 'a']++;
            windownFreq[s2[i] - 'a']++;
        }
        if(IsSame(freq, windownFreq)) return true;
        for(int right = s1.Length; right < s2.Length; right++) {
            windownFreq[s2[right] - 'a']++;
            
            int left = right - s1.Length;
            windownFreq[s2[left] - 'a']--;
            
            if(IsSame(freq, windownFreq)) return true;
        }

        return false;
    }

    private bool IsSame(int[] arr1, int[] arr2) {
        for(int i = 0; i < 26; i++) {
            if(arr1[i] != arr2[i]) return false;
        }
        return true;
    }
}
