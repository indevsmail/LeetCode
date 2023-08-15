namespace LeetCode.Easy
{
    internal class P4LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs) 
        {                
            int length=strs.Length;
            //Console.WriteLine($"string length is: {length}");
            string prefix=string.Empty;
            for(int i=0; i<strs[0].Length;i++)
            {
                char c=strs[0][i];
                Console.WriteLine(strs[0][i]);
                for(int j=1;j<strs.Length;j++)
                {                    
                    if(i>=strs[j].Length || c!=strs[j][i])
                    {
                        return prefix;
                    }                    
                }
                prefix +=c;
            }
            return prefix;
        }
    }
}