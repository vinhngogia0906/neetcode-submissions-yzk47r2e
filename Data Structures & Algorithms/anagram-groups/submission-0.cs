public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var answer = new Dictionary<string, List<string>>();
        foreach(string str in strs) {
            char[] str_chars = str.ToCharArray();
            Array.Sort(str_chars);
            string sortedKey = new string(str_chars);
            if(!answer.ContainsKey(sortedKey)) {
                answer[sortedKey] = new List<string>();
            }
            answer[sortedKey].Add(str);
        }
        return answer.Values.Select(x => x.ToList()).ToList();
    }
}
