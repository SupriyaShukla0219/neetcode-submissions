public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char,char> dict = new Dictionary<char,char>() 
            {
                {')','('},
                {']','['},
                {'}','{'}
            };
        foreach(var key in s){
            if (dict.ContainsKey(key))
            {
                if (stack.Count > 0 && stack.Peek() == dict[key])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(key);
            }
        }
        return stack.Count == 0;
    }
}
