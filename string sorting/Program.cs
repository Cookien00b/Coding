using System;
using System.Linq;
using System.Collections.Generic;

namespace string_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sorting("eA2a1E"));
        }

        class sorted{
            public char key {get;set;}
        }

        

        

        public static string sorting(string str) 
        {
            
            string order = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789";

            char[] orderArr = new char[order.Length];

            for(int i = 0; i<order.Length;i++){
                orderArr[i] = order[i];
            }
            sorted[] sortedString;
            

            for(int i = 0; i<str.Length;i++){
                sortedString = new sorted[] { key=str[i]};
            }

            IEnumerable<sorted> endString = sortedString.OrderBy(x => orderArr);

            

            return "Yeeet";

        }
    }
}
