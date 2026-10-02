public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new List<List<string>>();
        var dic = new Dictionary<string, List<string>>();

        for(int i=0; i<strs.Length; i++) // O(n)
        {
            var charArr = strs[i].ToCharArray(); // O(m)
            Array.Sort(charArr); // O(m log m)
            var sortedString = new string(charArr); // O(m)

            if(dic.ContainsKey(sortedString)) // O(m)
                dic[sortedString].Add(strs[i]); // O(m)
            else
                dic.Add(sortedString, new List<string>(){ strs[i] }); // O(m)
        }

        foreach (var item in dic) // O(n) -> Worst case -> No anagram strings
            result.Add(item.Value);

        // Final complexity -> O(n * mlogm) + O(n)
        // Simplified to  O(n * mlogm)
        return result;
    }
}
