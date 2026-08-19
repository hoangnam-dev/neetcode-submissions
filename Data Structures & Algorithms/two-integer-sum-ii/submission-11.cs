public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length - 1;
        int sum = 0;
        while(i < j) {
            sum = numbers[i] + numbers[j];
            if(sum == target) {
                return new int[]{i+1, j+1};
            }
            if(sum < target) {
                i++;
                continue;
            }
            if(sum > target) {
                j--;
                continue;
            }
        }
        return [];
    }
}
