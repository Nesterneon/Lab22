using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab22
{
    class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method1 начал работу");
            Console.WriteLine("Выводим массив:");
            Random random = new Random();
            int[] array = new int[10];
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                S += array[i];
                Console.Write("{0}", array[i]);
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.WriteLine("cумма элементов массива: {0}", S);
        }
        public static void Method2()
        {
            Console.WriteLine("Продолжение запущено");
            Console.WriteLine("Выводим массив:");
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write("{0}", array[i]);
            }
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент массива {0}", max);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запушен в главном методе.");
            Task task = Task.Run(() => Method1());
            task.Wait();
            Task task1 = Task.Run(() => Method2());
            task1.Wait();
            Console.WriteLine("Работа основного потока завершена.");
            Console.ReadKey();
        }
    }
}
