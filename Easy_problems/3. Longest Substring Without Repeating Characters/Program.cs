using System.Formats.Asn1;

namespace _3._Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if(s.Length == 0) return 0;

            string  ans = s.Substring(0, 1);
            int max = 1;
            bool changed;
            for (int i = 1; i < s.Length; i++)
            {
                max = Math.Max(max, ans.Length);
                changed = false;
                for(int j = 0; j < ans.Length; j++)
                    if (ans[j] == s[i])
                    {
                        if (j == ans.Length - 1)
                            ans = s.Substring(i, 1);
                        else
                            ans = ans.Substring(j + 1, ans.Length - j - 1) + s[i];
                        changed = true;
                        break;
                    }
                if (!changed)
                    ans += s[i];
            }
            max = Math.Max(max, ans.Length);

            return max;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.LengthOfLongestSubstring("dvdf"));
        }
    }
}