using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            #region // Пункт 1 >>
            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;
            #endregion 

            string FirstName = "", LastName = ""; //Объявление строковых переменных для записи имён и фамилий
            byte Age = 0;                         //переменая типа byte для записи возраста                                               
            ushort Heigh = 0;                     //Переменная для записи роста
            byte mark_History = 0, mark_Mathematics = 0, mark_RusLanguage = 0; //Переменные для записи баллов по предметам

            var WidthConsole = Console.WindowWidth / 2;     //Получаем размер консоли и её центр по ширине
            var HeightConsole = Console.WindowHeight / 2;   //Получаем размера консоли и её центр по высоте

            #region // Почему выбранны именно эти типы переменных >>
            /*
            Все типы данных были подобранны с учётом современных реалий:
            со строковыми переменными всё ясно
            переменной типа byte с её диапазоном (от 0 до 255) вполне хватит для записи возраста, 
            но может не хватить для роста, так как на земле встречаются люди выше 255 см... 
            поэтому для записи роста используется тип ushort
            ну а переменных типа byte, вполне хватит для записи баллов по предметам
            */
            #endregion

            Console.WriteLine("Введите Имя: ");                              // Вывод текста в консоль для ввода данных
            FirstName = Console.ReadLine();                                  // Ввод пользователем имени

            Console.WriteLine("Введите Фамилию: ");                          // Вывод текста в консоль для ввода данных
            LastName = Console.ReadLine();                                   // Ввод пользователем фамилии

            Console.WriteLine("Введите Возраст: ");                          // Вывод текста в консоль для ввода данных
            Age = byte.Parse(Console.ReadLine());                            // Ввод пользователем возраста

            Console.WriteLine("Введите Рост (см): ");                        // Вывод текста в консоль для ввода данных
            Heigh = ushort.Parse(Console.ReadLine());                        // Ввод пользователем роста

            Console.WriteLine("Введите Баллы по Истории: ");                 // Вывод текста в консоль для ввода данных
            mark_History = byte.Parse(Console.ReadLine());                   // Ввод пользователем баллов по истории

            Console.WriteLine("Введите Баллы по Математике: ");              // Вывод текста в консоль для ввода данных
            mark_Mathematics = byte.Parse(Console.ReadLine());               // Ввод пользователем баллов по математике

            Console.WriteLine("Введите Баллы по Русскому языку: ");         // Вывод текста в консоль для ввода данных
            mark_RusLanguage = byte.Parse(Console.ReadLine());              // Ввод пользователем баллов по русскому языку

            /* Создание новой переменной и подсчёт среднего балла по трём предметам
            тип переменной double из-за того, что результат полученный при делении, 
            как правило получается с плавающей точкой, поэтому тип byte здень не подойдёт */
            double mark_average = Convert.ToDouble(mark_History + mark_Mathematics + mark_RusLanguage) / 3;

            //Создание паттерна для вывода всех данных об ученике
            string pattern = $" \n|Имя: {FirstName} " +             // Внесение имени в паттерн
                $"\n|Фамилия: {LastName} " +                        // Внесение фамилии в паттерн
                $"\n|Возраст: {Age} " +                             // Внесение возраста в паттерн
                $"\n|Рост (см): {Heigh} " +                         // Внесение роста в паттерн
                $"\n|Баллы по Истории: {mark_History} " +           // Внесение баллов по истории в паттерн
                $"\n|Баллы по Математики: {mark_Mathematics} " +    // Внесение баллов по математике в паттерн
                $"\n|Баллы по Русскому языку: {mark_RusLanguage}" + // Внесение баллов по русскому языку в паттерн
                $"\n|=========================" +
                $"\n|Средний балл: " + mark_average.ToString("#.#"); // Внесение среднего балла по предметам в паттерн
                                                                     //(с учётом плавающей точки и создание маски для вывода данных)

            #region // Пункт 2 >>
            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.
            #endregion

            #region // Пункт 3 >>
            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;
            #endregion

            #region // Пункт 4 >>
            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев
            #endregion

            #region // Пункт 5 >>
            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.
            #endregion

            //Очистка консоли
            Console.Clear();

            /* Вариант вывода 1 (без установки текста по центру, не разобрался, как его прикрутить к паттерну, 
            а точнее как сделать вывод построчно в центре */

            //Установка курсора в центр консоли для вывода первой строки
            //Console.SetCursorPosition(WidthConsole, HeightConsole);
            // Console.WriteLine(pattern); // Вывод данных по паттерну!

            // Вариант вывода 2 с установкой текста по центру (немного колхозный вариант, но зато работает!)

            //Установка курсора в центр консоли для вывода первой строки
            Console.SetCursorPosition(WidthConsole - FirstName.Length, HeightConsole - 4);
            // Вывод имени
            Console.WriteLine("| Имя: " + LastName, 12);

            Console.SetCursorPosition(WidthConsole - FirstName.Length, HeightConsole - 3);
            // Вывод фамилии
            Console.WriteLine("| Фамилия: " + LastName, 12);

            Console.SetCursorPosition(WidthConsole - FirstName.Length, HeightConsole - 2);
            // Вывод возраста
            Console.WriteLine("| Возраст: " + Age, 12);

            Console.SetCursorPosition(WidthConsole - FirstName.Length, HeightConsole - 1);
            // Вывод роста
            Console.WriteLine("| Рост(см): " + Heigh, 12);

            Console.SetCursorPosition(WidthConsole - FirstName.Length, HeightConsole);
            // Вывод баллов по истории
            Console.WriteLine("| Баллы по Истории: " + mark_History, 12);

            Console.SetCursorPosition(WidthConsole - FirstName.Length, HeightConsole + 1);
            // Вывод баллов по математике
            Console.WriteLine("| Баллы по Математике: " + mark_Mathematics, 12);

            Console.SetCursorPosition(WidthConsole - FirstName.Length, HeightConsole + 2);
            // Вывод баллов по русскому языку
            Console.WriteLine("| Баллы по Русскому языку: " + mark_RusLanguage, 12);

            Console.SetCursorPosition(WidthConsole - FirstName.Length, HeightConsole + 3);
            // Вывод разделительной черты
            Console.WriteLine("| ============================", 12);

            Console.SetCursorPosition(WidthConsole - FirstName.Length, HeightConsole + 4);
            // Вывод среднего балла по предметам
            Console.WriteLine("| Средний балл: " + mark_average.ToString("#.#"), 12);

            Console.ReadKey(); // Задержка экрана
        }
    }
}