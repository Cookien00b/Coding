using System;

namespace Next_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextPrime(402));
    
        }

        public static int NextPrime(int num) 
        {
            bool isPrime = false;
            bool failed = false;
            while(isPrime == false){
                failed =false;
                for(int i = 2;i<num;i++){
                    
                    decimal notPrime = Convert.ToDecimal(num)/Convert.ToDecimal(i);
                    if ((notPrime % 1) == 0){
                        failed = true;
                        i = num;
                    }

                    
                }
                if(failed != true){
                    isPrime = true;
                }
                if (isPrime==false){
                    num++;
                }


            }
            return num;
        }
    }
}
