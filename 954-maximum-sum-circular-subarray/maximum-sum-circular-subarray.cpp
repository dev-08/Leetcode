class Solution {
public:
    int maxSubarraySumCircular(vector<int>& nums) {
         int totalSum = 0;

    int currMax = 0, maxSum = nums[0];
    int currMin = 0, minSum = nums[0];

    for (int num : nums) {
        currMax = max(num, currMax + num);
        maxSum = max(maxSum, currMax);

        currMin = min(num, currMin + num);
        minSum = min(minSum, currMin);

        totalSum += num;
    }

    // If all numbers are negative, totalSum - minSum becomes 0,
    // which is invalid because subarray must be non-empty.
    if (maxSum < 0) {
        return maxSum;
    }

    return max(maxSum, totalSum - minSum);
    }
};