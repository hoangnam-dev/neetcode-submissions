public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < strs.Count; i++) {
            sb.Append(strs[i].Length);
            sb.Append('#');
            sb.Append(strs[i]);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> decoded_strs = new List<string>();
        int i = 0;
        while(i < s.Length) {
            int len = 0;
            int j = i;
            while(s[j] != '#') {
                j++;
            }
            len = int.Parse(s.Substring(i, j-i));
            string str = s.Substring(j+1, len);
            decoded_strs.Add(str);
            i = j + len + 1;
        }
        return decoded_strs;
   }
}
