public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int x=0,y=0;
        for(int i=0;i<nums.Length;i++)
        {
            if (nums[i]==1)
            {
                y=y+1;
                continue;
            }
            else
            {
                if(y>x)
                {
                    x=y;
                }
                y=0;
            }
        }
        if (y>x)
        {
            x=y;
        }
        return x;
    }
    
}