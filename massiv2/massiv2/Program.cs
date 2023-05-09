using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv2
{
    internal class Program
    {
        static int[,] MatrixPower(int[,] matrix, int power)
        {
            // Шаг 1
            int[,] result = (int[,])matrix.Clone();

            // Шаг 2
            for (int p = 1; p < power; p++)
            {
                int[,] temp = new int[matrix.GetLength(0), matrix.GetLength(1)];

                // Шаг 2.2
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int sum = 0;
                        int min = int.MaxValue;

                        // Вычисляем значение элемента новой матрицы
                        for (int k = 0; k < matrix.GetLength(1); k++)
                        {
                            if (matrix[i, k] + matrix[k, j] < min)
                            {
                                min = matrix[i, k] + matrix[k, j];
                            }
                        }

                        temp[i, j] = min;
                    }
                }

                // Шаг 2.3
                result = temp;

                // Заменяем исходную матрицу на новую
                matrix = (int[,])temp.Clone();
            }

            return result;
        }

    }
}
