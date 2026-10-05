public class Solution {
    public void SortColors(int[] nums) {
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

            if(nums[i] == 2)
            {
                count2++;
                continue;
            }
        }

        // Bruteforce approach
        int index = 0;

        for(int i=0; i<count0; i++)
            nums[index++] = 0;

        for(int i=0; i<count1; i++)
            nums[index++] = 1;

        for(int i=0; i<count2; i++)
            nums[index++] = 2;
    }
}