public class Solution {
    public bool IsPalindrome(string s) {
       int pLeft = 0;
       int pRight = s.Length - 1;
       while(pLeft < pRight) {
        if(!char.IsLetterOrDigit(s[pLeft])) {
            pLeft++;
            continue;
        }
        if(!char.IsLetterOrDigit(s[pRight])) {
            pRight--;
            continue;
        }
        if(char.ToLower(s[pLeft]) != char.ToLower(s[pRight])) {
            return false;
        }
        
        pLeft++;
        pRight--;
       }
       return true;
    }
}
