using System;
using System.Collections.Generic;
using System.Linq;

namespace ммм
{

    class MainClass
    {
        static void Main()
        {
            const int n = 10; // число эл-тов массива
            Random rnd = new Random(DateTime.Now.Millisecond);
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
                array[i] = 50 - rnd.NextDouble() * 100; // заполняем случайными числами от -50 до 50
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0} ", array[i]);
            }
            Console.WriteLine();
            
            Console.WriteLine("ВВедите а ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("ВВедите b ");
            double b = double.Parse(Console.ReadLine());

            int count = array.Count(x => x >= a && x <= b); // количество элементов массива, лежащих в диапазоне от А до В; 
            Console.WriteLine("Кол в диапозоне");
            Console.WriteLine(count);
            int maxIndex = Array.IndexOf(array, array.Max(), 0, array.Count()); // индекс максимального элемента
            double summ = 0; // переменная под сумму
            for (int i = maxIndex + 1; i < n; i++)
                summ += array[i]; // считает сумму элементов массива, расположенных после максимального элемента. 
            Console.WriteLine("Сумма после макс");
            Console.WriteLine(summ);
            // Упорядочить элементы массива по убыванию модулей
            Console.WriteLine("Массив после перестановки");

            double[] reversedSorted = array.OrderByDescending(x => x).ToArray();

            Console.WriteLine(String.Join("  ", reversedSorted));
            Console.WriteLine();
        }
    }
}