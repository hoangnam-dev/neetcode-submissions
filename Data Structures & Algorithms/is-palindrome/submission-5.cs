public class Solution {
    public bool IsPalindrome(string s) {
       ReadOnlySpan<char> span = s.AsSpan();
       int pLeft = 0;
       int pRight = span.Length - 1;
       while(pLeft < pRight) {
        if(!char.IsLetterOrDigit(span[pLeft])) {
            pLeft++;
            continue;
        }
        if(!char.IsLetterOrDigit(span[pRight])) {
            pRight--;
            continue;
        }
        if(char.ToLower(span[pLeft]) != char.ToLower(span[pRight])) {
            return false;
        }
        
        pLeft++;
        pRight--;
       }
       return true;
    }
}
