public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] counter = new int[128];
        for(int i = 0; i < s.Length; i++){
            counter[s[i]]++;
            counter[t[i]]--;
        }
        for(int i = 0; i < 128; i++){
            if(counter[i] != 0) return false;
        }
        return true;
    }
}
