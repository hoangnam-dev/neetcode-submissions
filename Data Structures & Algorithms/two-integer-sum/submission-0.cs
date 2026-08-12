public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> result = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if(result.ContainsKey(nums[i])){
                return new int[] {result[nums[i]], i};
            }
            if(!result.ContainsKey(complement)) {
                result[complement] = i;
            }
        }
        return new int[0];
    }
}
