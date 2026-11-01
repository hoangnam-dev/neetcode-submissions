public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        int leftProduct = 1;
        int rightProduct = 1;
        for(int i = 0; i < nums.Length; i++){
            answer[i] = leftProduct;
            leftProduct *= nums[i];
        }
        for(int j = nums.Length - 1; j >= 0; j--){
            answer[j] *= rightProduct;
            rightProduct *= nums[j];
        }
        return answer;
    }
}
