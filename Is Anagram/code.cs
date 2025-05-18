public class Solution {
    public bool IsAnagram(string s, string t) {
         if (s.Length != t.Length)        
        return false;
        Dictionary<char, int> sChars = new Dictionary<char, int>();
 foreach (char c in s)
 {
     if (sChars.ContainsKey(c))
     {
         sChars[c]++;
     }
     else
     {
         sChars.Add(c, 1);
     }
 }
 foreach (char c in t)
 {
     if (sChars.ContainsKey(c))
     {
         sChars[c]--; 
         if (sChars[c] == 0)
         {
             sChars.Remove(c);
         }
     }
     else
     {
         return false;
     }
 }
 return true;
    }
}
