public class MinStack {
    private Stack<int> MainStack;
    private Stack<int> Min;
    public MinStack() {
        MainStack = new Stack<int>();
        Min = new Stack<int>();
    }
    
    public void Push(int val) {
        MainStack.Push(val);

        if( Min.Count == 0 ){
            Min.Push(val);}
        else{
            Min.Push(Math.Min(val,Min.Peek()));
        }
    }
    
    public void Pop() {
        MainStack.Pop();
        Min.Pop();
    }
    
    public int Top() {
        return MainStack.Peek();
        
    }
    
    public int GetMin() {
        return Min.Peek();
    }
}
