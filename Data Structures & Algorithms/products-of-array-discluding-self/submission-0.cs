public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        // multiply from left side of i
        answer[0] = 1;
        for(int i = 1; i < nums.Length; i++) {
            answer[i] = answer[i-1] * nums[i-1];
        }
        int right = 1;
        // multiply from the right side of i
        for(int i = nums.Length - 1; i >= 0; i--){
            answer[i] = right * answer[i];
            right = right * nums[i];
        }
        return answer;
    }
}
