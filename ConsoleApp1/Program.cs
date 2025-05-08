using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            string lastName = Console.ReadLine();

            point:
            Console.Write("Введите ваш возраст: ");
            int age = 0;
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Ошибка: введено некорректное значение для возраста. Пожалуйста, введите число.");
                goto point;
            }

            Console.WriteLine("Есть ли у вас питомец? (напишите да или нет) : ");
            string answer = Console.ReadLine();
            bool isPetExists = false;
            int petCount = 0;
            if (answer == "да")
            {
                isPetExists = true;
                Console.Write("Введите количество питомцев: ");
                petCount = int.Parse(Console.ReadLine());
            }

            string[] petNames = GetNames(petCount, "питомца");

            Console.Write("Введите количество ваших любимых цветов: ");
            int favouriteColorsCount = int.Parse(Console.ReadLine());

            string[] favouriteColors = GetNames(favouriteColorsCount, "цвета");

            var person = GetInformation(name, lastName, age, isPetExists, petNames, favouriteColors);

            Console.WriteLine($"Имя: {person.Item1} {person.Item2}");
            Console.WriteLine($"Возраст: {person.Item3}");
            if (isPetExists)
            {
                Console.WriteLine($"Есть ли питомец: да");
                Console.WriteLine($"Питомцы: {string.Join(", ", person.Item5)}");
            }
            Console.WriteLine($"Есть ли питомец: нет");
            Console.WriteLine($"Любимые цвета: {string.Join(", ", person.Item6)}");
        }

        public static Tuple<string, string, int, bool, string[], string[]> GetInformation( 
        string name, string lastName,
        int age, bool isPetExists, 
        string[] petNames, string[] favouriteColors)
        {
            return Tuple.Create(name, lastName, age, isPetExists, petNames, favouriteColors);
        }

        public static string[] GetNames(int count, string str)
        {
            string[] strings = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите имя вашего {str}");
                strings[i] = Console.ReadLine();
            }
            return strings;
        }
    }
}