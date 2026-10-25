public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] mFreq = new int[26];
        for(int i = 0; i < magazine.Length; i++){
            int idx = magazine[i] - 'a';
            mFreq[idx]++;
        }
        for(int j = 0; j < ransomNote.Length; j++){
            int idx = ransomNote[j] - 'a';
            if(mFreq[idx] > 0){
                mFreq[idx]--;
            }
            else {
                return false;
            }
        }
        return true;
    }
}