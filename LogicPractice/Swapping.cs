using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractice
{
    public class Swapping
    {
        // int number1 = 10, number2 = 20, temp= 0;

        public void SwappingNumber(int number1, int number2)
        {
            Console.WriteLine("\nWith using third variable\n");
            Console.WriteLine($"Before swapping number1= {number1}, number2 = {number2}");
            int temp = 0;
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");
            //Console.ReadKey();
        }

        public void SwappingNumberWithoutUsingThirdVaribleAstricSign(int number1, int number2)
        {
            Console.WriteLine("\nWithout using third variable but (*) sign\n");
            Console.WriteLine($"Before swapping number1= {number1}, number2 = {number2}");
            number1 = number1 * number2;
            number2  = number1 / number2;
            number1 = number1 / number2;
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");
        }

        public void SwappingNumberWithourUsingThirdVariableButPlusSign(int number1, int number2)
        {
            Console.WriteLine("\nWithout using third variable but (+) sign\n");
            Console.WriteLine($"Before swapping number1= {number1}, number2 = {number2}");

            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");
        }
    }
}
