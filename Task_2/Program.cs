using System;

namespace Task_2
{
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var calculator = new Calculator(Logger);
            calculator.WriteNumbers();

            Console.ReadKey();
        }
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(message);
        }
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
