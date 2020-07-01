using System;
using System.Linq;

namespace Reverse_and_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseAndNot(12345));
        }
        public static string ReverseAndNot(int i) {
        return string.Join(string.Empty, i.ToString().ToArray().Reverse())+i.ToString();	
		}
    }
}
