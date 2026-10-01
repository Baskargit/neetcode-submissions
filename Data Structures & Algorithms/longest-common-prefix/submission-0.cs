public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder sb = new StringBuilder();
        char[] strs0 = strs[0].ToCharArray();

        for(int i=0; i<strs[0].Length; i++)
        {
            for(int j=1; j<strs.Length; j++)
            {
                if(i >= strs[j].Length || strs0[i] != strs[j].ToCharArray()[i])
                    return sb.ToString();
            }

            sb.Append(strs0[i]);
        }

        return sb.ToString();
    }
}