using System;
using System.Collections.Generic;

namespace Remove_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates list of numbers to check
            int[] removeTheOdds = {1, 2, 3, 4, 5, 6};
            //Checks said numbers and removes odd numbers
            int[] zeroOdds = NoOdds(removeTheOdds);
            //Writes all numbers to the console;
            for(int i = 0; i<zeroOdds.Length;i++){
                Console.WriteLine(zeroOdds[i]);
            }
            
        }

        public static int[] NoOdds(int[] arr)
        {
            //Creates a list to add all values to
            List<int> zeroOdds = new List<int>();
            //checks if a number is an odd number by deviding by 2
            for(int i = 0; i<arr.Length;i++){
                decimal odds= Convert.ToDecimal(arr[i])/2m;
                //Checks if there is anything left over
                if ((odds % 1) == 0){
                    zeroOdds.Add(arr[i]);
                }
            }   
            //Returns all non odd numbers in an array
            return zeroOdds.ToArray();
        }
    }
}
