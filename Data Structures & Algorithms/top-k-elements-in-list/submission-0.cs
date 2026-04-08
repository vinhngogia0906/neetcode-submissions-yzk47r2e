public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // hashmap to store key and frequency
        var myMap = new Dictionary<int, int>();
        // populate it
        foreach(int num in nums) {
            myMap[num] = myMap.GetValueOrDefault(num) + 1;
        }
        return myMap.OrderByDescending(pair => pair.Value)
        .Take(k).Select(p => p.Key).ToArray();
    }
}
