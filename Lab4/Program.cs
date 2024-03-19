using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {


        
   
        static void Main()
        {
            int[] numbers = { 12,5,3,8,5,3,11,14,9,111111111 }; // Ваше множество чисел

            // Сортируем числа в порядке убывания
            Array.Sort(numbers);
            Array.Reverse(numbers);

            List<int> subset1 = new List<int>(); // Первое подмножество
            List<int> subset2 = new List<int>(); // Второе подмножество

            foreach (int num in numbers)
            {
                // Добавляем текущее число к меньшей сумме
                if (subset1.Sum() <= subset2.Sum())
                    subset1.Add(num);
                else
                    subset2.Add(num);
            }

            // Выводим результат
            Console.WriteLine("Первое подмножество: " + string.Join(", ", subset1));
            Console.WriteLine("Второе подмножество: " + string.Join(", ", subset2));
        }
    }


}
  

