public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder sb = new StringBuilder();
        char[][] converted = new char[strs.Length][];

        // Fill the jagged array
        for(int i=0; i<strs.Length; i++)
        {
            converted[i] = strs[i].ToCharArray();
        }

        // Bruteforce approach
        for(int i=0; i<strs[0].Length; i++)
        {
            for(int j=1; j<strs.Length; j++)
            {
                if(i >= strs[j].Length || converted[0][i] != converted[j][i])
                    return sb.ToString();
            }

            sb.Append(converted[0][i]);
        }

        return sb.ToString();
    }
}