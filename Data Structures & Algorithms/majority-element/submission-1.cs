public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> dic = new Dictionary<int,int>(); // O(n/2)
        int count = 0, maxNum = nums[0];

        for(int i=0; i<nums.Length; i++) // O(n)
        {
            if(dic.ContainsKey(nums[i]))
            {
                dic[nums[i]]++;

                if(dic[nums[i]] > count)
                {
                    maxNum = nums[i];
                    count = dic[nums[i]];
                }
            }
            else
            {
                dic.Add(nums[i], 1);
            }
        }

        // Time: O(n)
        // Space: O(n)
        return maxNum;
    }
}