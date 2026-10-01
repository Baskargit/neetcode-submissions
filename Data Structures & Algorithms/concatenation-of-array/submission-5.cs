public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[n*2];

        // Approach 1
        // for (int i = 0; i < n; i++)
        // {
        //     ans[i] = nums[i];
        //     ans[i+n] = nums[i];
        // }

        // Approach 2
        Array.Copy(nums, 0, ans, 0, n);
        Array.Copy(nums, 0, ans, n, n);

        return ans;
    }
}