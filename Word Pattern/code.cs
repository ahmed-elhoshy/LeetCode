public class Solution {
    public bool WordPattern(string pattern, string s) {
      var dict = new Dictionary<char, string>();
        var spl = s.Split(' ');

        if(pattern.Length != spl.Length){
            return false;
        }

        for(var p = 0; p<pattern.Length; p++){
            if(dict.ContainsKey(pattern[p])){
                if(dict[pattern[p]] != spl[p]){
                    return false;
                }
            }else{
                if(dict.ContainsValue(spl[p])){
                    return false;
                }
                dict.Add(pattern[p], spl[p]);
            }
        }

        return true;
}
}
