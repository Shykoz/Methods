using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowMethod(5, 4));
        }
        public static int PowMethod(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }
    }
}
