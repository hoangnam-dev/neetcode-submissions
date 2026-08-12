public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> unique = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            if(unique.ContainsKey(nums[i])){
                return true;
            }
            unique.Add(nums[i], i);
        }
        return false;
    }
}