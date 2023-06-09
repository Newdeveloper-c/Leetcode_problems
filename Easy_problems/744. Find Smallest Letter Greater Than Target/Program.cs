namespace _744._Find_Smallest_Letter_Greater_Than_Target
{
    public class Solution
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            char ans = letters[0];
            bool isFirstTime = true;
            foreach (char c in letters)
            {
                if(c > target)
                if(isFirstTime)
                {
                        ans = c;
                        isFirstTime = false;
                }                   
                ans = (ans < c)? ans : c;
            }
            return ans;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.NextGreatestLetter(new char[] { 'c', 'f', 'j' }, 'a'));
        }
    }
}