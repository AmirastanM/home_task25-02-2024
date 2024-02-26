using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Tasks_22_02_2024
{
    internal class CustomMath
    {

        

        //1-Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin.
        public int SumOfOddNumbers(int[] array)
        {
            int sum = 0;
            foreach (var number in array)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }
            return sum;
        }


        //2-Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.
        public  void CheckNums(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Cuttur");
            }
            else
            {
                Console.WriteLine("Tekdir");
            }
        }


        //3-Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
        public  int SquareSumOfEvenNumbers(int[] array)
        {
            int sum = 0;
            foreach (var number in array)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum * sum;
        }


        //4-Methoda n ededi gelir, 1-den n ededine qeder olan ededlerin hasilini tapin.
        public  int FindElem(int a)
        {
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

