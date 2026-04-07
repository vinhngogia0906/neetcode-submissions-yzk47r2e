public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // use Hashmap
        var map = new Dictionary<int, int>(); // value -> index
        for(int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if(map.ContainsKey(complement))
                return [map[complement], i];
            // populate the dictionary and record index, not frequency
            map[nums[i]] = i;
        }
        return [];
    }
}
