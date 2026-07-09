public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
       int res=0,count=0;
       foreach(int num in nums)
       {
        count = (num ==1) ? count +1 : 0;
        res = Math.Max(res,count);
       }
        return res;
    }
    
}