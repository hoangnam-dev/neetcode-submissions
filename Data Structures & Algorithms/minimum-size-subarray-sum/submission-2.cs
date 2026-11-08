public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int l = 0;
        int sum = 0;
        int minLength = int.MaxValue;
        for(int r = 0; r < nums.Length; r++){
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