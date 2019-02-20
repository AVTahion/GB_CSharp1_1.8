using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System;

/* 
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

namespace Task_3
{
    // Класс для вопроса    
    [Serializable]
    public class Question
    {
        public string text;       // Текст вопроса
        public bool trueFalse;// Правда или нет
                              // Здесь мы нарушаем правила инкапсуляции и эти поля нужно было бы реализовать через открытые свойства, но для упрощения примера оставим так
                              // Вам же предлагается сделать поля закрытыми и реализовать открытые свойства Text и TrueFalse
                              // Для сериализации должен быть пустой конструктор.
        public Question()
        {
        }
        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }
    }

    // Класс для хранения списка вопросов. А также для сериализации в XML и десериализации из XML
    class TrueFalse
    {
        string fileName;
        List<Question> list;

        public string FileName
        {
            set { fileName = value; }
        }

        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        /// <summary>
        /// Метод добавляет новый вопрос
        /// </summary>
        /// <param name="text"></param>
        /// <param name="trueFalse"></param>
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }

        /// <summary>
        /// Метод удаляет вопрос
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        // Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get { return list[index]; }
        }

        /// <summary>
        /// Метод сериализует список в xml и сохраняет в фаил
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        /// <summary>
        /// Метод сериализует список в xml и сохраняет в фаил с заданным именем
        /// </summary>
        /// <param name="fileName"></param>
        public void Save(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        /// <summary>
        /// Метод загружает из файла xml десериализуя список
        /// </summary>
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}
