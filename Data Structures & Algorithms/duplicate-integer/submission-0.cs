public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dupe = new HashSet<int>();
        foreach(int x in nums)
        {
            if (!dupe.Add(x))
                return true;
        }
            return false;

    }
}