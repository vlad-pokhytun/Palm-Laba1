using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            int sum = 0;
            Console.Write("масив випадкових чисел = ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-50, 50);
                Console.Write("{0},", array[i]);
                if (array[i] % 2 != 0)
                {
                    sum += array[i] * array[i];
                }
            }
            Console.WriteLine();
            Console.Write("Масив впорядкований за спаданням = ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int step = array[i];
                        array[i] = array[j];
                        array[j] = step;
                    }
                }
                Console.Write("{0},", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Сумма квадратів непарних чисел - {0}", sum);
            Console.ReadKey();

        }
    }
}
