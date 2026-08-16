public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach(int n in nums) {
            if(!frequency.ContainsKey(n)) {
                frequency.Add(n, 0);
            }
            frequency[n]++;
        }
        int[] topK = frequency.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        return topK;
    }
}
