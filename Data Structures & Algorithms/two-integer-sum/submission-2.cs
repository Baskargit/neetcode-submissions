public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];

        // Bruteforce apporach
        // for(int i=0; i<nums.Length; i++)
        //     for(int j=i+1; j<nums.Length; j++)
        //         if(nums[i] + nums[j] == target)
        //             return new int[]{i,j};

        Dictionary<int, int> dic = new Dictionary<int,int>();

        // O(n) time and O(n) space
        for(int i=0; i<nums.Length; i++)
        {
            int diff = target - nums[i];

            if(dic.ContainsKey(diff))
                return new int[] { dic[diff], i};
            else
                dic.Add(nums[i], i);
        }

        return result; 
    }
}
