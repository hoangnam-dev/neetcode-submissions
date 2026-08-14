public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length == 0) return [[""]];
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
        for(int i = 0; i < strs.Length; i++) {
            string sortS = new string(strs[i].OrderBy(w => w).ToArray());
            if(!groups.ContainsKey(sortS)){
                groups.Add(sortS, new List<string>());
            }
            groups[sortS].Add(strs[i]);
        }
        return groups.Values.ToList();
    }
}
