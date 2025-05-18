 public bool BackspaceCompare(string s, string t)
 {
     bool equal = true;
     if (s.Contains("#"))
     {
         foreach (char c in s)
         {
             if (c == '#')
             {
                 int index = s.IndexOf(c);
                 s = s.Remove(index, 1);
                 if (index > 0)
                 {
                     s = s.Remove(index - 1, 1);
                 }
             }
         }


     }
     if (t.Contains("#"))
     {
         foreach (char c in t)
         {
             if (c == '#')
             {
                 int index = t.IndexOf(c);
                 t = t.Remove(index, 1);
                 if (index > 0)
                 {
                     t = t.Remove(index - 1, 1);
                 }
             }
         }

     }

     if (s.Length != t.Length)
     {
         equal = false;
     }
     else
     {
         for (int i = 0; i < s.Length; i++)
         {
             if (s[i] != t[i])
             {
                 equal = false;
             }

         }
     }

     return equal;

 }
