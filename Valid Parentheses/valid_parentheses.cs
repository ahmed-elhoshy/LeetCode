public class Program
{
    public static bool checkBrackets(string str)
    {
        bool result = false;
        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(' || str[i] == '[' || str[i] == '{') // check for first part only
            {
                stack.Push(str[i]);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char top = stack.Peek();
                if ((top == '(' && str[i] == ')') || (top == '[' && str[i] == ']') || (top == '{' && str[i] == '}'))
                {
                    stack.Pop();
                }
                else
                {
                    return false;  
                }
            }
        }
        if (stack.Count == 0)
        {
            result = true;
        }
        return result;

    }
  /// another solution with o(n^2)
  //while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        // {
        //     s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
        // }

        //return s.Length == 0;
    public static void Main(string[] args)
    {
        string str = "({[]})";
        if (checkBrackets(str))
        {
            WriteLine("1.Balanced");
        }
        else
        {
            WriteLine("1.Not Balanced");
        }
        string str2 = "()[]{}";
        if (checkBrackets(str2))
        {
            WriteLine("2.Balanced");
        }
        else
        {
            WriteLine("2.Not Balanced");
        }
        string str3 = "(]";
        if (checkBrackets(str3))
        {
            WriteLine("3.Balanced");
        }
        else
        {
            WriteLine("3.Not Balanced");
        }

    }
}
