public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();

        foreach (var str in strs) // O(n)
        {
            int[] freq = new int[26]; // O(1) space
            foreach (var c in str) { // O(m)
                freq[c - 'a']++;
            }

            string key = string.Join("", freq); // O(m)

            if(dic.ContainsKey(key))
                dic[key].Add(str); // O(m)
            else
                dic.Add(key, new List<string>() { str });
        }

        // O(n * m)
        return dic.Values.ToList();
    }
}
