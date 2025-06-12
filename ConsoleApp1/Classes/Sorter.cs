using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Classes
{
    internal class Sorter
    {
        List<string> last_names;

        public Sorter(List<string> l_names)   //конструктор для поля Фамилий
        {
            last_names = l_names;
        }

        public List<string> Sort(byte typeOfSort)
        {
            if (typeOfSort == 1)   //определения типы сортировки
            {
                return last_names.OrderBy(last_name => last_name).ToList();   //сортровка по алфавиту
            }
            if (typeOfSort == 2)
            {
                return last_names.OrderByDescending(last_name => last_name, StringComparer.CurrentCulture).ToList();   //обратная сортровка по алфавиту
            }
            return last_names;
        }
    }
}
