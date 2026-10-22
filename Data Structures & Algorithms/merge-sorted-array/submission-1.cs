public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int n1Len = nums1.Length;

        for (int i = nums2.Length - 1; i >= 0; i--)
        {
            nums1[n1Len - 1 - i] = nums2[i];
        }
        for (int i = 0; i < n1Len; i++)
        {
            for (int j = i + 1; j < n1Len; j++)
            {
                if(nums1[j] < nums1[i])
                {
                    int temp = nums1[i];
                    nums1[i] = nums1[j];
                    nums1[j] = temp;
                }
            }
        }
    }
}