public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new List<List<string>>();
        var dic = new Dictionary<string, List<string>>();

        for(int i=0; i<strs.Length; i++)
        {
            var charArr = strs[i].ToCharArray();
            Array.Sort(charArr);
            var sortedString = new string(charArr);

            if(dic.ContainsKey(sortedString))
                dic[sortedString].Add(strs[i]);
            else
                dic.Add(sortedString, new List<string>(){ strs[i] });
        }

        foreach (var item in dic) 
            result.Add(item.Value);

        return result;
    }
}
