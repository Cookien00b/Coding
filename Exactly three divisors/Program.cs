using System;
using System.Linq;
using System.Collections.Generic;

namespace Exactly_three_divisors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(isExactlyThree(999966000289));
        }

        public static bool isExactlyThree(long n) {
            List<int> primeNumbersList = new List<int>();
            int temp;
            bool done = false;
            while(done!=true){
                isPrime(n);
                if(isPrime(n)==true){
                    primeNumbersList.Add(Convert.ToInt32(n));
                    break;
                }
                int div = Convert.ToInt32(nextDivisor(n));
                primeNumbersList.Add(div);
                n = n/div;
            }
            int[] primeNumbers = primeNumbersList.ToArray();
            //int maxValue = primeNumbers.Max();
            //int maxIndex = primeNumbersList.IndexOf(maxValue);
            int[] allDivs = primeNumbers.ToList().Distinct().ToArray();
            if (allDivs.Length>1)return false;

            //foreach(int x in allDivs){
                //Console.WriteLine(x);
            //}
            
            if(primeNumbers.Length+1==3)return true;



            return false;
        }

        static bool isPrime(long num){
            bool failed = false;
            for(int i = 2;i<num;i++){
                    
                decimal notPrime = Convert.ToDecimal(num)/Convert.ToDecimal(i);
                //if the number devides from something else then 1 and itself it will stop the for loop
                if ((notPrime % 1) == 0){
                    failed = true;
                    break;
                }
                    
            }
            if (failed!=true) return true;
            return false;
        }
        static long nextDivisor(long n){
            int i = 2;
            while(n%i != 0 && i<=n){
                i = Convert.ToInt32(NextPrime(i));
            }
            if (i>n){
                i = 4;
                while(n%i != 0 && i<=n){
                i++;
                }
                
            }
            return i;
        } 

        static long NextPrime(int num) 
        {
            num += 1;
            bool isPrime = false;
            bool failed = false;
            //Keeps checking until the next prime number is found
            while(isPrime == false){
                failed =false;
                //checks if current number is a prime
                for(int i = 2;i<num;i++){
                    
                    decimal notPrime = Convert.ToDecimal(num)/Convert.ToDecimal(i);
                    //if the number devides from something else then 1 and itself it will stop the for loop
                    if ((notPrime % 1) == 0){
                        failed = true;
                        i = num;
                    }

                    
                }
                //if it is a prime number it returns true and leaves the while statement
                if(failed != true){
                    isPrime = true;
                }
                //if it isn't a prime number it increases it by one and checks again
                if (isPrime==false){
                    num++;
                }


            }
            return num;
        }
    }
}
