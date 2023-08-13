// See https://aka.ms/new-console-template for more information
namespace LeetCode.Easy
{
        class Programs
        {
            static void Main(string[] args)
            {
                Console.WriteLine("The Leet Code Easy problems!");
                Console.WriteLine("1. Two Sum!");
                Console.WriteLine("2. Add Two Numbers!");
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
                        default: Console.WriteLine("No case matched");
                                break;
                }

                Console.ReadLine();
            }    
        }
}
