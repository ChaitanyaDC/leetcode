namespace leetcode.challenges.TwoPointers._125ValidPalindrome;


public class Solution {
    public bool IsPalindrome(string s) {
        {
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            else if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
            }
            else if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            else
            {
                left++;
                right--;
            }
        }

        return true;
        }
    }
}


public static class _125ValidPalindrome {

    public static void Test() {
        // Example usage:
        // string s = "A man, a plan, a canal: Panama";
        string s = s = "race a car";

        Solution sol = new();
        bool result = sol.IsPalindrome(s);
        Console.WriteLine("Is the string a palindrome? " + result);
    }
}