public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> record = new Stack<int>();

        foreach(var op in operations)
        {
            if (op == "+")
            {
                int top = record.Pop();
                int second = record.Peek();
                record.Push(top);
                record.Push(top + second);
            }
            else if(op == "D")
                record.Push(2 * record.Peek());
            else if(op == "C")
                record.Pop();
            else
                record.Push(int.Parse(op));
            
        }
        int total=0;
        foreach(var op in record){
            total+=op;
        }
        return total;
    }
}