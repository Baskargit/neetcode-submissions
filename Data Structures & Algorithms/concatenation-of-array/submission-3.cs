public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length*2];
        for (int i=0,j=0; i < 2 * nums.Length; i++, j = j < nums.Length - 1 ? j+1 : 0)
            ans[i] = nums[j];

        return ans;
    }
}