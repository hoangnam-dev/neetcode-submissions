public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int sum = nums[0];
        int minLength = sum >= target ? 1: int.MaxValue;
        if(minLength == 1) return 1;
        
        int l = 0;
        for(int r = 1; r < nums.Length; r++){
            if(nums[r] >= target) return 1;

            sum += nums[r];
            
            while(sum >= target){
                minLength = Math.Min(minLength, r - l + 1);
                sum -= nums[l];
                l++;
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}