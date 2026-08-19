public class Solution {
    public bool IsPalindrome(string s) {
        string regex = "[^a-zA-Z0-9]"; 
        string str = Regex.Replace(s.ToLower(), regex, "");
        StringBuilder sb = new StringBuilder(str);
        sb.Replace(" ", "");
        int i = 0;
        int j = sb.Length - 1;
        while(i < sb.Length) {
            if(sb[i] != sb[j]) {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
