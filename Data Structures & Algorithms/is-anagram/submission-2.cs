public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        // O(1) space
        int[] count = new int[26];

        // O(n) time
        for(int i=0; i<s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }   

        // O(1) time
        for(int i=0; i<count.Length; i++)
            if(count[i] != 0)
                return false;

        return true;
    }
}
