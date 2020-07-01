using System;

namespace Find_the_missing_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MissingNum(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 }));
        }
        public static int MissingNum(int[] arr)
        {
            int total = 0;
            foreach(int x in arr){
                total += x;
            }
            return 55-total;
        }
    }
}
