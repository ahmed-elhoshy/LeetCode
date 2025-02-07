using System;

class Program
{
    static void Main(string[] args)
    {
        string haystack = "sadbutsad";
        string needle = "sad";
        int result = StrStr(haystack, needle);
        Console.WriteLine(result); 

        haystack = "hello";
        needle = "ll";
        result = StrStr(haystack, needle);
        Console.WriteLine(result); 

        haystack = "leetcode";
        needle = "leeto";
        result = StrStr(haystack, needle);
        Console.WriteLine(result);
    }

    static int StrStr(string haystack, string needle)
    {
        if (haystack.Contains(needle))
        {
            int index = haystack.IndexOf(needle);
            return index;
        }
        else
        {
            return -1;
        }
    }
}
