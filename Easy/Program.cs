// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

namespace LeetCode.Easy
{
        class Programs
        {
            static void Main(string[] args)
            {
                Console.WriteLine("The Leet Code Easy problems!");
                Console.WriteLine("1. Two Sum!");
                Console.WriteLine("2. Add Two Numbers!");
                Console.WriteLine("3. Roman to Integer!");
                Console.WriteLine("4. Common Longest Prefix!");
                Console.WriteLine("5. Valid Parenthesis!");
                Console.Write("Choose the problem number: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                        case 1: Console.WriteLine("Two Sum problem");
                                TwoSum obj=new TwoSum();
                                obj.TwoSumProcess();
                                break;
                        case 2: Console.Write("Please enter number: ");
                                int input = Convert.ToInt32(Console.ReadLine());
                                Palindrome obj2=new Palindrome();
                                obj2.Process(input);
                                break;
                        case 3: Console.Write("Please enter Roman number: ");
                                var strInput = Console.ReadLine();
                                if(String.IsNullOrEmpty(strInput))
                                        Console.WriteLine($"You have not entered any string");
                                else
                                {
                                        P3RomanToInteger p3=new P3RomanToInteger();
                                        int result = p3.RomanToInt(strInput);
                                        Console.WriteLine($"The Integer number is: {result}");
                                }                                
                                break;
                        case 4: //Console.Write("Please enter number: ");
                                //int input = Convert.ToInt32(Console.ReadLine());
                                //string[] strs = new string[]{"flight", "flow", "flower"};
                                string[] strs = new string[]{"ab", "a"};
                                P4LongestCommonPrefix obj4=new P4LongestCommonPrefix();
                                string prefix = obj4.LongestCommonPrefix(strs);
                                Console.WriteLine($"Logest common prefix is: {prefix}");
                                break;
                        case 5: Console.Write("Please parenthesis string: ");
                                var parenthesisInput = Console.ReadLine();       
                                if(String.IsNullOrEmpty(parenthesisInput))                         
                                        Console.WriteLine($"You have not entered any string.");
                                else
                                {
                                        P5ValidParentheses obj5=new P5ValidParentheses();
                                        //string prefix = obj4.LongestCommonPrefix(strs);
                                        //Console.WriteLine($"Logest common prefix is: {prefix}");                                
                                }
                                break;                                
                        default: Console.WriteLine("No case matched");
                                break;
                }

                Console.ReadLine();
            }    
        }
}
