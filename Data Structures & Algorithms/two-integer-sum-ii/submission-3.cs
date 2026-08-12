public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // ================== Hash table ==================
        // Dictionary<int, int> map = new Dictionary<int, int>();
        // for (int i = 0; i < numbers.Length; i++){
        //     int diff = target - numbers[i];
        //     if(map.ContainsKey(diff)){
        //         return new int[]{ map[diff] + 1, i + 1 };
        //     }
        //     else {
        //         map.Add(numbers[i], i);
        //     }
        // }
        // return new int[0];


        // ================== Two Pointer ==================
        int l = 0;
        int r = numbers.Length - 1;
        while(l<r) {
            int sum = numbers[l] + numbers[r];
            
            if(sum > target){
                r--;
            }
            else if(sum < target){
                l++;
            }
            else {
                return new int[2] { l+1, r+1 };
            }
        }
        return new int[0];
    }
}
