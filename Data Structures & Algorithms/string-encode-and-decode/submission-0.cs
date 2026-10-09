public class Solution {

    public string Encode(IList<string> strs) {
        return string.Join("~Z@1`", strs);
    }

    public List<string> Decode(string s) {
        return s.Split("~Z@1`").ToList();
   }
}
