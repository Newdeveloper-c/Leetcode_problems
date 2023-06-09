namespace _347._Top_K_Frequent_Elements
{
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(dict.TryAdd(nums[i], 1) == false)
                    dict[nums[i]]++;
            }
                
                
            var sortedDict = from entry in dict orderby entry.Value descending select entry;
            int[] ans = new int[k];
            int it = 0;
            foreach(var j in sortedDict)
            {
                ans[it] = j.Key; 
                it++;
                if(it == k)
                    break;
            }
            return ans;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var ans = s.TopKFrequent(new int[] { 1}, 1);
            foreach(int i in ans) 
            { 
                Console.WriteLine(i);
            }
        }
    }
}