using System;

public class Solution
{
    //public int LengthOfLastWord(string s)
    //{
    //    int i = s.Length - 1;
    //    int count = 0;

    //    while (i != -1)
    //    {
    //        if (s[i] == ' ' && count == 0)
    //        {
    //            i--;
    //        }
    //        else if (s[i] == ' ' && count != 0)
    //        {
    //            return count;
    //        }
    //        else
    //        {
    //            count++;
    //            i--;
    //        }

    //    }
    //    return count;
    //}
    public int LengthOfLastWord(string s)
    {
        return s.TrimEnd().Split(' ')[^1].Length;
    }
}
