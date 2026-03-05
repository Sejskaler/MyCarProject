using Microsoft.VisualBasic.FileIO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double FuelPrice = 0.0;
            double Price = 0.0;
            double Distance = 0.0;
        }
        static bool IsPalindrome(int km)
        {
            string kmString = km.ToString();
            char[] kmPalindrome = kmString.ToCharArray();
            Array.Reverse(kmPalindrome);
            string kmStringReversed = new string(kmPalindrome);
            if (kmString == kmStringReversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }





    }
}
        