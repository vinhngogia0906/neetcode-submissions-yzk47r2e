public class Solution {

    public string Encode(IList<string> strs) {
        string encodedStr = "";
        // reverse the string list
        var reversedStr = strs.Reverse();
        // take string length followed by ~ as delimiter
        foreach(string str in reversedStr){
            encodedStr += str.Length + "~" + str;
        }
        return encodedStr;
    }

    public List<string> Decode(string s) {
        var decodedList = new List<string>();
        int i = 0;
         while (i < s.Length) {
          // find the next delimiter
          int tilde = s.IndexOf('~', i);

          // parse the full length number (handles 1, 10, 100, etc.)
          int len = int.Parse(s.Substring(i, tilde - i));

          // extract the string after ~
          decodedList.Add(s.Substring(tilde + 1, len));

          // jump past: digits + ~ + string
          i = tilde + 1 + len;
      }
        decodedList.Reverse();
        return decodedList;
   }
}
