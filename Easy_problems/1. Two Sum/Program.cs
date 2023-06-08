namespace _1._Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int res = 0;
            for(int i = 0; i < nums.Length; i++) 
                for(int j = i + 1; j < nums.Length; j++)
                {
                    res = nums[i] + nums[j];
                    if (res == target)
                        return new int[2] { i, j};
                }
            return new int[2] {0, 0};
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var pr = solution.TwoSum(new int[] { 3, 2, 3 }, 6);
            foreach(int i in pr)
            {
                Console.WriteLine(i);
            }
        }
    }
}