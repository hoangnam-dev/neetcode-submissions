public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;

        int[] s1Feq = new int[26];
        int[] windowFeq = new int[26];

        for(int i = 0; i < s1.Length; i++){
            s1Feq[s1[i] - 'a']++;
            windowFeq[s2[i] - 'a']++;
        }
        if(s1Feq.SequenceEqual(windowFeq)) return true;

        for(int j = s1.Length; j < s2.Length; j++){
            windowFeq[s2[j - s1.Length] - 'a']--;
            windowFeq[s2[j] - 'a']++;

            if(s1Feq.SequenceEqual(windowFeq)) return true;
        }

        return false;
    }
}
