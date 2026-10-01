public class Solution {
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length;

        // Approach 1: Brute-force
        // for(int i=0; i<n; i++)
        //     for(int j=i+1; j<n; j++)
        //         if(nums[i] == nums[j])
        //             return true;

        // Approach 2: HashSet
        HashSet<int> set = new HashSet<int>();

        for(int i=0; i<n; i++)
            if(!set.Add(nums[i]))
                return true;

        return false;
    }
}