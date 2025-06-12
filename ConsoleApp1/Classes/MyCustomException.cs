using System;

namespace ConsoleApp1.Classes
{
    public class MyCustomException : SystemException   //наследование об базового класса
    {
        public MyCustomException() { } //1-ый конструктор

        public MyCustomException(string message) : base(message) { }   //2-ый конструктор

        public MyCustomException(string message, Exception inner) : base(message, inner) { }   //3-ый конструктор

        public override string Message => "Введённое число не соответствует указанным!";   //переопределение свойства
    }
}
