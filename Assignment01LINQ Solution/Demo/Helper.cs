using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper
    {
        public static void Print(this int A)
        {
            Console.WriteLine($"Variable Value = {A}");
        }
    }
}
