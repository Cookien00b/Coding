using System;

namespace Reverse_binary_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(reversedBinaryInteger(5));
        }

        public static int reversedBinaryInteger(int num) 
        {
		//converts the number to its binary equal in string form
			string binNum = Convert.ToString(num, 2);
		//write the binary number to the console
            Console.WriteLine(binNum);
            string reversedNum = "";
		//Keeps adding the first, second... etc to the end of the string to reverse the string
			for (int i = binNum.Length; i>0; i-- ){
                reversedNum = reversedNum + binNum[i-1].ToString();
            }
		//writes the inverted binary number to the console
            Console.WriteLine(reversedNum);
		//Converts the binary string to the number it represents and returns it
            return Convert.ToInt32(reversedNum, 2);
        }
    }
}
