using ConsoleApp1.Classes;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            Logger logger = new Logger();
            try
            {
                Console.WriteLine("Введите первое число!");
                double number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число!");
                double number2 = int.Parse(Console.ReadLine());
                Calculator calculator = new Calculator(number1, number2);   //Создание класса
                number = calculator.Sum();   //Cумирование
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);   //Вывод в консоль текста ошибки
                logger.Info(ex.StackTrace);   //Вывод в консоль информации об ошибке
                return;
            }
            Console.WriteLine($"Сумма ваших чисел: {number}");
        }
    }
}