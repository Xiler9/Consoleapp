using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;   //Изменение цвета
            Console.WriteLine($"Ошибка: {message}");   //Вывод текста ошибки
            Console.ResetColor();   //Сброс цвета
        }

        public void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;   //Изменение цвета
            Console.WriteLine($"Информация: {message}");   //Вывод сообщения ошибки
            Console.ResetColor();   //Сброс цвета
        }
    }
}
