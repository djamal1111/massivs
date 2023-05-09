using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 2, 7, 8, 3, 6, 9 };
            List<int> odds = new List<int>();

            // Используем цикл для добавления нечётных элементов в новый массив
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    odds.Add(nums[i]);
                }
            }

            // Сортируем новый массив по возрастанию
            odds.Sort();

            // Преобразуем список в массив и выводим его на экран
            int[] result = odds.ToArray();
            Console.WriteLine(string.Join(", ", result)); // Выведет: 3, 5, 7, 9
        }
    }
}
