public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] rs = new int[2];
        int i = 0;
        int j = numbers.Length - 1;
        int sum = 0;
        while(i < j) {
            sum = numbers[i] + numbers[j];
            if(sum < target) {
                i++;
                continue;
            }
            if(sum > target) {
                j--;
                continue;
            }
            if(sum == target) {
                rs[0] = i + 1;
                rs[1] = j + 1;
                return rs;
            }
        }
        return rs;
    }
}
