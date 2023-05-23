using System;

namespace Task_2
{
    internal class Calculator : ISum
    {
        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        
        public void WriteNumbers()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("Введите первое число: ");
                    string firstNumberUser = Console.ReadLine();
                    Console.Write("Введите второе число: ");
                    string secondNumberUser = Console.ReadLine();

                    if (int.TryParse(firstNumberUser, out int numberOne) && int.TryParse(secondNumberUser, out int numberTwo))
                    {
                        Logger.Event("Сумма двух чисел: ");
                        Console.WriteLine(Sum(numberOne, numberTwo));
                        break;
                    }
                    else throw new IncorrectDataException("Введены некорретные данные! Повторите попытку.");
                }
                catch (IncorrectDataException ex)
                {
                    Logger.Error(ex.Message);
                }
                catch(Exception ex)
                {
                    Logger.Error($"Ошибка: {ex.Message}");
                }
            }
        }

        public int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
