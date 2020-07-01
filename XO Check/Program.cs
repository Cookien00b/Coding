using System;

namespace XO_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XO("xooxx"));
        }

        public static bool XO(string str) 
        {
            int x = 0;
            int o = 0;
            foreach(char X in str){
                if(X=='X'||X=='x') x++;
                if(X=='O'||X=='o') o++;
            }
            if(x==o)return true;
            
            return false;
      
        }
    }
}
