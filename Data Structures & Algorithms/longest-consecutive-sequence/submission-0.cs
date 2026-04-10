public class Solution {
    public int LongestConsecutive(int[] nums) {
        // hashset
        var num_set = new HashSet<int>(nums);
        int max_count = 0;
        foreach(int num in num_set) {
            if(!num_set.Contains(num-1)){
                int current_count = 1;
                while(num_set.Contains(num+current_count)) {
                    current_count++;
                }
                max_count = Math.Max(max_count, current_count);
            }
        }
        return max_count;
    }
}
