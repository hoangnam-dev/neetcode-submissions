public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 1)
        {
            return 1;
        }
        int i = 0;
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[i] != nums[j])
            {
                i++;
                nums[i] = nums[j];
            }
        }
        return i + 1;
    }
}