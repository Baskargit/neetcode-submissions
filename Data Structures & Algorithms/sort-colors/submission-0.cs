public class Solution {
    public void SortColors(int[] nums) {
        int[] result = new int[nums.Length];
        int count0 = 0, count1 = 0, count2 = 0;

        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                count0++;
                continue;
            }

            if(nums[i] == 1)
            {
                count1++;
                continue;
            }
            
        }
    }
}