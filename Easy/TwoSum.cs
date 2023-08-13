namespace LeetCode.Easy
{
    public class TwoSum
    {
        public void TwoSumProcess()
        {
            int[] num = new int[5] {2,5,3,8,7};
            int t = 9;
            Dictionary<int, int> numDict = new();
            int[] result = new int[2];
            foreach(int j in num)
                Console.Write(j);
            Console.WriteLine("");
            for (int i=0; i<5; i++)
            {
                int a = num[i];
                int b = t-num[i]; 
                if(numDict.TryGetValue(b, out int index))
                {                                        
                    result[0] = index;
                    result[1]= i;
                    Console.WriteLine($"Index is: {index} and {i}");
                    return;
                }
                numDict[a]=i;
            }
            foreach(int j in result)
                Console.WriteLine(j);            
        }
    }
}
