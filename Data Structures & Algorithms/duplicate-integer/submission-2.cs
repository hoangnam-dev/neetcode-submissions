public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length <= 0) return false;
        HashSet<int> unique = new HashSet<int>();
        foreach(int num in nums){
            if(!unique.Add(num)) return true;
        }
        return false;
    }
}