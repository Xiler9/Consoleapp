using ConsoleApp1.Classes;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackOverflowException stackOverflowException = new StackOverflowException();
            ArgumentNullException argumentNullException = new ArgumentNullException();
            IndexOutOfRangeException indexOutOfRangeException = new IndexOutOfRangeException();
            DivideByZeroException divideByZeroException = new DivideByZeroException();
            MyCustomException myCustomException = new MyCustomException();
            Exception[] exceptions =   // занесение исключений в список 
            { 
                stackOverflowException, 
                argumentNullException, 
                indexOutOfRangeException, 
                divideByZeroException, 
                myCustomException 
            };
            try
            {
                //throw exceptions[];   выброс одного из исключений
            }
            catch (StackOverflowException SOE)    //обработка каждого исключения
            {
                Console.WriteLine(SOE.Message);
            }
            catch (ArgumentNullException ANE)
            {
                Console.WriteLine(ANE.Message);
            }
            catch (IndexOutOfRangeException IOORE)
            {
                Console.WriteLine(IOORE.Message);
            }
            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine(DBZE.Message);
            }
            catch (MyCustomException MCE)
            {
                Console.WriteLine(MCE.Message);
            }
            finally
            {
                Console.WriteLine("Будьте внимательны!");   //сообщение для блока finally
            }



            List<string> last_names = new List<string>();   //иницилизация списка фамилий, похже добавление
            last_names.Add("Петров");
            last_names.Add("Александрова");
            last_names.Add("Сидоров");
            last_names.Add("Щербакова");
            last_names.Add("Ященко");
            Sorter sorter = new Sorter(last_names);   //иницилизация класса сортровщика
            Console.WriteLine("Введите 1 или 2, где 1 сортировка А-Я, а 2 сортировка Я-А).");
            byte typeOfSort = byte.Parse(Console.ReadLine());   //записывание типа сортировки
            if (typeOfSort != 1 && typeOfSort != 2) throw new MyCustomException();   //проверка на правильность набора
            var sorted_last_names = sorter.Sort(typeOfSort);   //получение отсортированного списка
            for (int i = 0; i < sorted_last_names.Count; i++)
            {
                Console.WriteLine(sorted_last_names[i]);   //вывод нового списка
            }
        }
    }
}