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
            int index = s.IndexOf("#", i);
            if(index == -1) break;
            string l = s.Substring(i, index-i);
            if(!int.TryParse(l, out int len)) break;
            int start = index + 1;
            string str = s.Substring(start, len);
            decoded_strs.Add(str);
            i = start + len;
        }
        return decoded_strs;
   }
}
