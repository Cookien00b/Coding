using System;

namespace Next_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sends a number to check if its a prime and writes the output to the console
            Console.WriteLine(NextPrime(402));
    
        }

        public static int NextPrime(int num) 
        {
            
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
