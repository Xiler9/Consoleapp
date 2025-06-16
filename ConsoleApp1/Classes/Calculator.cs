using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
    public class Calculator : ISumer
    {
        public double number1;
        public double number2;
        
        public Calculator(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public double Sum() => number1 + number2;   //реализация метода инферфейса
    }
}
