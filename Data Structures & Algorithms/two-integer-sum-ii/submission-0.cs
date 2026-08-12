public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        // Hash table
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++){
            int diff = target - numbers[i];
            if(map.ContainsKey(diff)){
                return new int[]{ map[diff] + 1, i + 1 };
            }
            else {
                map.Add(numbers[i], i);
            }
        }
        return new int[0];
    }
}
