using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string StringBool)
        {

            var isPalindrome = "";
            for (int i = StringBool.Length - 1; i >= 0; i--)
            {
                isPalindrome += StringBool.ToLower()[i];
            }
            if (isPalindrome == StringBool.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
