namespace Calculator
{
    public class PalindromeChecker
    {
        public bool IsPalindrone(string a)
        {
           string str = a.ToLower();
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;


        }
    }
}
