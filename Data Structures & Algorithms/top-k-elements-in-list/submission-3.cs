public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int n in nums) {
            dict[n] = dict.GetValueOrDefault(n, 0) + 1;
        }
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        foreach(var i in dict) {
            queue.Enqueue(i.Key, i.Value);
            if(queue.Count > k) {
                queue.Dequeue();
            }
        }
        int[] topK = new int[k];
        for(int i = 0; i < k; i++) {
            topK[i] = queue.Dequeue();
        }
        return topK;
    }
}
