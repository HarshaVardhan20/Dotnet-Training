using System.Text.RegularExpressions;

namespace Extensions
{
    /// <summary>
    /// Provides extension methods for performing common operations on strings.
    /// </summary>
    /// <remarks>This static class contains methods that extend the functionality of the <see cref="string"/>
    /// type, enabling additional string analysis and manipulation operations. All methods are implemented as extension
    /// methods and can be called directly on string instances.</remarks>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the number of words in the specified string, using spaces as word separators.
        /// </summary>
        /// <remarks>This method considers a word to be any sequence of characters separated by spaces.
        /// Multiple consecutive spaces and leading or trailing spaces may affect the result. The method does not
        /// account for punctuation or other whitespace characters as word boundaries.</remarks>
        /// <param name="str">The string to count words in. Cannot be null.</param>
        /// <returns>The number of words found in the input string. Returns 1 if the string contains no spaces.</returns>
        public static int WordCount(this string str)
        {
            char[] chars = str.ToCharArray();
            int count = 1;
            foreach (var item in chars)
            {
                if (item.Equals(' '))
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Determines whether the specified string is a palindrome.
        /// </summary>
        /// <remarks>The comparison is case-sensitive and considers all characters, including whitespace
        /// and punctuation. An empty string is considered a palindrome.</remarks>
        /// <param name="str">The string to evaluate for palindrome characteristics. Cannot be null.</param>
        /// <returns>true if the string reads the same backward as forward; otherwise, false.</returns>

        public static bool IsPalindrome(this string str) { 
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j]) return false;
                i++;
                j--;     
            }
            return true;
        }
    }

    /// <summary>
    /// Provides the entry point for the application.
    /// </summary>

    public class Program
    {
        static void Main(string[] args)
        {            

            if ("madam".IsPalindrome())
            {
                Console.WriteLine("madam is palindrome");
            }
            else
            {
                Console.WriteLine("madam is not palindrome");
            }

            try
            {
                string input = "Error: TIMEOUT while calling API";
                string pattern = @"timeout";
                var rx = new Regex(pattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(0.2));  
                Console.WriteLine(rx.IsMatch(input) ? "Found" : "Not Found");
            }
            catch(RegexMatchTimeoutException)
            {
                Console.WriteLine("Time out");
            }
        }
    }
}