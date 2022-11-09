/*Двумерные массивы
Осуществить циклический сдвиг элементов прямоугольной матрицы на n - элементов
вправо или вниз(в зависимости от введенного режима), n может быть больше количества элементов в строке или столбце.*/


using System;
using System.Collections.Generic;
using System.Text;


using System.Linq;
namespace LabRab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массив элементов
            const int z = 4, x = 5;
            int[,] a = new int[z, x];



            Random r = new Random();

            for (int i = 0; i < z; i++)
                for (int j = 0; j < x; j++)
                    a[i, j] = r.Next(-1, 1);

            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < x; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }
            //Вводим количество элементов для  сдвига
            Console.Write("Введите количество элементов для  сдвига: ");
            string buf1 = Console.ReadLine();
            int n = int.Parse(buf1);
            //Ввдим режим сдвига
            Console.Write("Выберите режим сдвига( 1 - вправо, 2 - вниз ): ");
            string buf2 = Console.ReadLine();
            int sd = int.Parse(buf2);
            //Осуществляем сдвиги
            int inew = 0, jnew = 0;
            int g = 0;
            if (sd == 1)
            {
                Console.WriteLine("Сдвиг вправо:");
                int nnew = x - n % x; // Выносим повторяющиеся вычисления за пределы цикла
                for (int i = 0; i < z; ++i)
                {
                    inew = i;
                    for (int j = 0; j < x; ++j)
                    {
                        jnew = (j + nnew) % x;
                        Console.Write("\t" + a[inew, jnew]);
                    }
                    Console.WriteLine();
                }
            }
            else if (sd == 2)
            {
                Console.WriteLine("Сдвиг вниз:");
                int nnnew = z - n % z; // Выносим повторяющиеся вычисления за пределы цикла
                for (int i = 0; i < z; ++i)
                {
                    for (int j = 0; j < x; ++j)
                    {
                        jnew = j;
                        inew = (i + nnnew) % z;
                        Console.Write("\t" + a[inew, jnew]);
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Ошибка!");
            //Ввыводим массив со сдвигом
            Console.ReadLine();
        }
    }
}