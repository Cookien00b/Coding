using System;

namespace Reverse_binary_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = reversedBinaryInteger(5);
            Console.WriteLine(test);
        }

        public static int reversedBinaryInteger(int num) 
        {
			string binNum = Convert.ToString(num, 2);
            Console.WriteLine(binNum);
            string reversedNum = "";
			for (int i = binNum.Length; i>0; i-- ){
                reversedNum = reversedNum + binNum[i-1].ToString();
            }

            Console.WriteLine(reversedNum);

            return Convert.ToInt32(reversedNum, 2);
        }
    }
}
