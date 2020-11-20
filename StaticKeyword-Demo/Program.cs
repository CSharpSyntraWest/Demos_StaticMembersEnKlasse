using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
        //static method kan aangeroepen worden via de Class naam
           Console.WriteLine( SqrtPrecalculated.CalculateSqrt(9));
            //non-methode moet eerst een instantie van de class worden gemaakt
            //voordat deze kan worden aangeroepen
          /* SqrtPrecalculated precalc = new SqrtPrecalculated();
            Console.WriteLine(precalc.CalcSqrtNotStatic(9));*/
           Console.ReadLine();
        }
    }
    static class SqrtPrecalculated //static utility class
    {
        public const int MAX_VALUE = 10000;
        // Static field 
        private static int[] sqrtValues;
        // Static constructor 
        static SqrtPrecalculated()
        {
            sqrtValues = new int[MAX_VALUE + 1];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }
        public static double CalculateSqrt(int value) //static method
        {
            //return Math.Sqrt(value);
            return sqrtValues[value];
        }
       /* public double CalcSqrtNotStatic(int value) //non-static method
        {
            return Math.Sqrt(value);
        }*/
    }
}