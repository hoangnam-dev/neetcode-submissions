public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < strs.Count; i++) {
            sb.Append((char)strs[i].Length);
            sb.Append(strs[i]);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> decoded_strs = new List<string>();
        int len, i = 0;
        string str;
        while(i < s.Length) {
            len = s[i];
            int start = i + 1;
            str = s.Substring(start, len);
            decoded_strs.Add(str);
            i = start + len;
        }
        return decoded_strs;
   }
}
