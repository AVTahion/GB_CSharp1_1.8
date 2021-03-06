﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*  1.  С помощью рефлексии выведите все свойства структуры DateTime
    2.  Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
    3.  а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок(не создана база данных,
        обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
        б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
        в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
        г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).
    4.  * Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных
        (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
    5.  ** Написать программу-преобразователь из CSV в XML-файл с информацией о студентах(6 урок).

 Александр Кушмилов
*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Type t = typeof(DateTime);
            Console.WriteLine("Properties:");
            System.Reflection.PropertyInfo[] memberInfo = t.GetProperties();

            foreach (System.Reflection.PropertyInfo mInfo in memberInfo)
                Console.WriteLine(mInfo.ToString());

            Console.ReadKey();
        }

    }
}