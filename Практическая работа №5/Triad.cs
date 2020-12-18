using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__5
{
    /// <summary>
    /// Создать класс Triad (тройка отрицательных чисел).
    /// Создать необходимые методы и свойства.
    /// Определить метод увеличения полей на 1.
    /// Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения всех чисел на 10.
    /// </summary>
    class Triad
    {
        //поля класс(отриц числа)
        private int negativenumber1;
        private int negativenumber2;
        private int negativenumber3;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="numb1">первое отриц число</param>
        /// <param name="numb2">второе отриц число</param>
        /// <param name="numb3">третье отриц число</param>
        public Triad(int numb1, int numb2, int numb3)
        {
            //Если числа положительные выбрасываем исключение
            if (numb1 >= 0 || numb2 >= 0 || numb3 >= 0)
            {
                throw new ArgumentException("Введите отрицательные числа");
            }

            negativenumber1 = numb1;
            negativenumber2 = numb2;
            negativenumber3 = numb3;
        }

        //Свойство 1 числа
        public int Number1
        {
            //Возвращаем значенин
            get
            {
                return negativenumber1;
            }
            //Устанаваливаем значение
            set
            {
                //Если число положительное выбрасываем исключение
                if (value >= 0)
                {
                    throw new ArgumentException("Введите отрицательное число");
                }

                negativenumber1 = value;
            }
        }

        //Свойство 2 числа
        public int Number2
        {
            //Возвращаем значение
            get
            {
                return negativenumber2;
            }
            //Устанавливаем значение
            set
            {
                //Если число положительное выбрасываем исключение
                if (value >= 0)
                {
                    throw new ArgumentException("Введите отрицательное число");
                }

                negativenumber2 = value;
            }
        }

        //Свойство 3 числа
        public int Number3
        {
            //Ыозвращаем значение
            get
            {
                return negativenumber3;
            }
            //Устанавливаем значение
            set
            {
                //Если число положительное выбрасываем исключение
                if (value >= 0)
                {
                    throw new ArgumentException("Введите отрицательное число");
                }

                negativenumber3 = value;
            }
        }
        /// <summary>
        /// Метод увеличения полей 
        /// </summary>
        //Метод увеличения полей на 1
        public void FieldNumber()
        {
            negativenumber1++;
            negativenumber2++;
            negativenumber3++;
        }

        //Метод увелечения полей на 10
        public void FieldNumber(int countAdd = 10)
        {
            negativenumber1 += countAdd;
            negativenumber2 += countAdd;
            negativenumber3 += countAdd;
        }

        /// <summary>
        /// Метод установки параметров полей
        /// </summary>
        /// <param name="n1"></param>
        //Метод установки параметров 1 числа
        public void SetParams(int n1)
        {
            negativenumber1 = n1;
        }

        //Метод установки параметров 1 и 2 числа
        public void SetParams(int n1, int n2)
        {
            negativenumber1 = n1;
            negativenumber2 = n2;
        }

        //Метод установки параметров 1,2 и 3 числа
        public void SetParams(int n1, int n2, int n3)
        {
            negativenumber1 = n1;
            negativenumber2 = n2;
            negativenumber3 = n3;
        }
    }
}
