using System.ComponentModel.DataAnnotations;

namespace LeetCode.Easy
{
    internal class P3RomanToInteger
    {
        public int RomanToInt(string s) 
        {           
            Dictionary<char, int> romanToint = new()
            {
                {'M',1000},
                {'D',500},
                {'C',100},
                {'L',50},
                {'X',10},
                {'V',5},
                {'I',1}
            };
            int result=0;
            for(int i=0; i<s.Length; i++)
            {                
                romanToint.TryGetValue(s[i], out int num);
                if(i+1<s.Length && romanToint[s[i+1]] > romanToint[s[i]])
                    result = result - num;
                else
                    result = result + num;
            }            
            return result;            
        }
    }
}