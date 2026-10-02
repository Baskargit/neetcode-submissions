public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int occurrence = 0;
        int ptr = 0;

        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] != val)
                nums[ptr++] = nums[i];
            else
                occurrence++;
        }

        return nums.Length - occurrence;
    }
}