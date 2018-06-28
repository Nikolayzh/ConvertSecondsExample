using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            int i = 0, cur, max = 1, curmax = 1;
            int border;
            int prev;
            Console.WriteLine("Введите количество членов цепочки:");
            // Весь блок алгоритма заключаем в try/catch для перехвата исключений
            try
            {
                // Ввод количества элементов и перевод их в int
                border = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваш выбор {0} элементов последовательности", border);
                // Создаём объект класса Random для генерации случайного числа
                // Начальная точка основывается на системном времени 
                Random rand = new Random();
                Console.WriteLine("Вот элементы последовательности:");
                // Генерируется случайное число от 0 до 100		
                prev = rand.Next(0, 100);
                Console.WriteLine("{0}", prev);
                do
                {
                    // Генерируется случайное число от 0 до 100		
                    cur = rand.Next(0, 100);
                    if (cur >= prev)
                        curmax++;
                    else
                    {
                        if (curmax > max)
                            max = curmax;
                        curmax = 1;
                    }
                    prev = cur;
                    Console.WriteLine("{0}", cur);
                    i++;
                } while (i < border - 1);

                if (curmax > max)
                    max = curmax;
                // Показ полученного результата
                Console.WriteLine("\n\nМаксимальная Длина = {0}\n\n", max);
            }
            // Обработка исключительной ситуации
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Не повезло !!!\n");
            }
            // Задержка перед выходом							
            Console.Read();
        }
    }
}
