/*
 1) Визначити ітератор для обчислення бітових наборів(у вигляді string) для 3 бітів. 
Тобто ітератор повинен повертати набори(рядки) : "000", "001", "010", "011", "100" ,,,, "111".
 * Підказка: можна скористатися Convert.ToString(число, 2) або організувати три вкладені цикли(по кожній цифрі окремо)
 */


using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_iterator
{
    class Program
    {
        static IEnumerable<string> Bits(int n)
        {

            string bits;
            int k;
            for (int i = 0; i <= n; i++)
            {
                bits = null;
                k = i;
                for (int k1 = 0; k1 < 3; k1++)
                {
                    if (k % 2 == 0)
                        bits += '0';
                    else
                        bits += '1';
                    k /= 2;
                }
                yield return new string(bits.ToCharArray().Reverse().ToArray());
                if (i >= 7)
                    yield break;
            }

        }
        

    static void Main(string[] args)
        {
            int count = 0;
            foreach (var number in Bits(10))
            {
                Console.WriteLine($"({count++})\t{number}");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
