public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;
        foreach(int num in set) {
            if(!set.Contains(num - 1)) {
                int cur = num;
                int count = 1;
                while(set.Contains(cur + 1)) {
                    cur++;
                    count++;
                }
                if(longest < count) longest = count;
            }
        }
        return longest;
    }

    // public int LongestConsecutive(int[] nums) {
    //     if(nums.Length == 0) return 0;
    //     if(nums.Length == 1) return 1;
    //     Array.Sort(nums);
    //     int longest = 0;
    //     int count = 1;
    //     for(int i = 0; i < nums.Length - 1; i++) {
    //         if(nums[i] != nums[i + 1]) {
    //             if(nums[i] + 1 == nums[i+1]) {
    //                 count++;
    //             }
    //             else {
    //                 if(count > longest){
    //                     longest = count;
    //                 }
    //                 count = 1;
    //             }
    //         }
    //     }
    //     if(count > longest) longest = count;
    //     return longest;
    // }
}
