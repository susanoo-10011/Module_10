using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Calculator : ISum
    {

        public void WriteNumbers()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    string firstNumberUser = Console.ReadLine();
                    Console.Write("Введите второе число: ");
                    string secondNumberUser = Console.ReadLine();

                    if (int.TryParse(firstNumberUser, out int numberOne) && int.TryParse(secondNumberUser, out int numberTwo))
                    {
                        Console.Write("Сумма двух чисел: ");
                        Console.WriteLine(Sum(numberOne, numberTwo));
                        break;
                    }
                    else throw new Exception();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message} Повторите попытку");
                }
            }
        }

        public int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
