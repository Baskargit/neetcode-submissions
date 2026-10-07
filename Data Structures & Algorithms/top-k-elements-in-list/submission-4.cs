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

        List<int>[] bucket = new List<int>[nums.Length + 1];

        foreach (var item in dic) 
        {
            if(bucket[item.Value] == null)    
                bucket[item.Value] = new List<int>() {item.Key};
            else
                bucket[item.Value].Add(item.Key);
        }

        int[] result = new int[k];
        int index = 0;

        for(int i=bucket.Length - 1; i>=0 && index < k; i--)
        {
            if(bucket[i] != null)
            {
                foreach (var item in bucket[i])
                {
                    if(index < k)
                        result[index++] = item;
                    else
                        return result;
                }
            }
        }

        return result;
    }
}
