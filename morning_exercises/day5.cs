public static class CheckValid
{
    public static bool isValid(string input)
    {
        var stack = new Stack<char>();
        var mappings = new Dictionary<char, char>
        {
            ['}'] = '{',
            [')'] = '(',
            [']'] = '['
        };

        foreach (char c in input)
        {
            if (c=='{' || c=='[' || c=='(') stack.Push(c);
            else
            {
                if (stack.Count==0) return false;

                if(mappings[c]!=stack.Peek()) return false;
                stack.Pop();
            }
        }
        return stack.Count==0;
    }
}