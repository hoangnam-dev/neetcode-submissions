public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0 || strs[0].Length == 0) return "";
        StringBuilder sb = new StringBuilder(strs[0]);
        for(int i = 1; i < strs.Length; i++){
            if(sb.Length > strs[i].Length){
                sb.Length = strs[i].Length;
            }
            int currentLength = sb.Length;
            for(int j = 0; j < currentLength; j++ ){
                if(sb[j] != strs[i][j]){
                    sb.Length = j;
                    break;
                }
            }
            if(sb.Length == 0) return "";
        }
        return sb.ToString();
    }
}