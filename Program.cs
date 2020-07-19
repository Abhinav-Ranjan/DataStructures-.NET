using System;
using System.Text.RegularExpressions;

namespace DataStructures_.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            //string tempinput = "a mom'a";
            //string tempinput = "racecar";
            //string tempinput = "noon";
            //string tempinput = "a mom's";
            string tempinput = "Was it a car or a cat I saw";
            //string tempinput = " Mr. Owl ate my metal worm";


            Regex re = new Regex("\\s|'|\\.");
            string input = re.Replace(tempinput,string.Empty);
            Console.WriteLine(input);
            if(isPalindrome(input))
                Console.WriteLine($"The word {tempinput} string is a palindrome");
            else
                Console.WriteLine($"The word {tempinput} string is not a palindrome");
        }
        private static bool isPalindrome(string str)
        {
             int leftPointer = 0;
             int rightPointer = str.Length -1;
             for(int i=0;i<=str.Length/2; i++)
             {
                 if(!(str[leftPointer].ToString().ToLower() == str[rightPointer].ToString().ToLower()))
                 {
                     return false;
                 }
                 leftPointer++;
                 rightPointer--;
             }
             return true;
        }
    }
}
