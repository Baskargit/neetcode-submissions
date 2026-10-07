public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dic = new Dictionary<int,int>();

        foreach (var num in nums) 
        {
            if(dic.ContainsKey(num))
                dic[num]++;
            else
                dic.Add(num, 1);    
        }

        return dic.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();

    }
}
