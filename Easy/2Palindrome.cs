using System.Globalization;

namespace LeetCode.Easy
{
    internal class Palindrome
    {
        public void Process(int x)
        {        
            int rev = Reverse(x);    
            Console.WriteLine($"Reverse of number is: {rev}");
            if(x == rev)
                Console.WriteLine($"{x} is palindrom number.");
            else
                Console.WriteLine($"{x} is NOT palindrom number.");
        }

        public int Reverse(int x)
        {
            int result=0;
            while (x>0)
            {
                result=result*10 + x%10;
                x=x/10;
            }
            return result;
        }
    }
}