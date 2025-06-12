using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Classes
{
    public delegate void Notify(byte typeOfSort);

    internal class Sorter
    {
        public event Notify Notify;
        List<string> last_names;
        public List<string> sortedList;

        public Sorter(List<string> l_names)   //конструктор для поля Фамилий
        {
            last_names = l_names;
            sortedList = new List<string>();
        }

        public void Sort(byte typeOfSort)
        {
            if (typeOfSort == 1)   //определения типы сортировки
            {
                sortedList = last_names.OrderBy(last_name => last_name).ToList();   //сортровка по алфавиту
            }
            if (typeOfSort == 2)
            {
                sortedList = last_names.OrderByDescending(last_name => last_name, StringComparer.CurrentCulture).ToList();   //обратная сортровка по алфавиту
            }
        }

        public void RaiseEvent(byte typeOfSort)
        {
            Notify?.Invoke(typeOfSort);  // Вызов события
        }
    }
}
