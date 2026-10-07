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

        int?[] bucket = new int?[nums.Length + 1];

        foreach (var item in dic) 
            bucket[item.Value] = item.Key; 

        int[] result = new int[k];
        int index = 0;

        for(int i=bucket.Length - 1; i>=0 && index < k; i--)
        {
            if(bucket[i].HasValue)
                result[index++] = bucket[i].Value;
        }

        return result;
    }
}
