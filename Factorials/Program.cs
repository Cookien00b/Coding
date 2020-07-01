using System;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(3));
        }

        public static int factorial(int num) {
            int[] factoNum = new int[num];
            //get all numbers to multiply to get factorial
            for(int i = 0; i<=num-1; i++){
                factoNum[i] = num-i;
            }
            int factorialNum = 1;
            //multiplies said numbers
            foreach (int value in factoNum)
            {
                factorialNum *= value;
            }
            //returns the final awnser
            return factorialNum;
	    }
    }
}
