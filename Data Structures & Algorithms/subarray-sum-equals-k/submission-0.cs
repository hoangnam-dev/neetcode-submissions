public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int prefixSum = 0;
        int count = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>{[0]=1};
        for(int i = 0; i < nums.Length; i++){
            prefixSum += nums[i];
            int need = prefixSum - k;
            if(dict.ContainsKey(need)){
                count += dict[need];
            }
            
            if(dict.ContainsKey(prefixSum)){
                dict[prefixSum]++;
            }
            else {
                dict.Add(prefixSum, 1);
            }
        }
        return count;
    }
}