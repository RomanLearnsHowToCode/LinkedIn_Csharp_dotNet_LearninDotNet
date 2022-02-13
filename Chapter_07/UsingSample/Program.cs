using System;
using static System.Math; // compiler won't recognise line 21 without using
using static System.Console; // compiler won't recognise line 18 without using

namespace UsingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_UsingSimplified();
        }

        /// <summary>
        /// Using static clause
        /// </summary>
        /// without Using
        static private void Test_UsingSimplified()
        {
            WriteLine
                ($"The comedy club cost me {Round(59.87):C}");

        }
    }
}
