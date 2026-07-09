public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxVal = -1, n = arr.Length;
        if( maxVal == 0)
        {
            arr[n-1] = -1;
        }
        for(int i = n-1; i >= 0; i--)
        {
            int current = arr[i];
            arr[i] = maxVal;
            maxVal = Math.Max(maxVal,current);
            
        }
        return arr;
    }
}