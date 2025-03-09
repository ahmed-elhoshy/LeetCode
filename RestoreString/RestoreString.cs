using System;

class Program
{
   
     public string RestoreString(string s, int[] indices)
    {
        string result = "";

        for (int i = 0; i < indices.Length; i++)
        {
            result += s[Array.IndexOf(indices, i)];
        }

        return result;
    }
 

    static void Main(string[] args)
    {
        int[] indices = new int[] { 4, 5, 6, 7, 0, 2, 1, 3 };
        Program p = new Program();
     
        Console.WriteLine(p.RestoreString("codeleet", indices));
    }
}
