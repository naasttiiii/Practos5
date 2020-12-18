using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__5
{
    //Создать класс Triad (тройка отрицательных чисел). 
    //Создать необходимые методы и свойства. 
    //Определить метод увеличения полей на 1. 
    //Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения всех чисел на 10.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Triad triadNumbers;

        //Кнопка увеличение полей на 1
        private void btnNumberPlus1_Click(object sender, EventArgs e)
        {
            //3 отриц числа получаем от пользователя
            int number1 = (int)numUpDownNumber1.Value;
            int number2 = (int)numUpDownNumber2.Value;
            int number3 = (int)numUpDownNumber3.Value;

            //создание увеличения полей на 1
            try
            {
                triadNumbers = new Triad(number1, number2, number3);//создание объекта класса

                //вызов метода класса
                triadNumbers.FieldNumber();

                txtNumberPlus1.Text = string.Format("{0} {1} {2}", triadNumbers.Number1, triadNumbers.Number2, triadNumbers.Number3);//выводим ответ в текстовое поле 

            }
            //Обрабатывам исключение(орицательные числа)
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message);
            }

        }

        //Кнопка увеличение полей на 10
        private void btnNumberPlus10_Click(object sender, EventArgs e)
        {
            //3 отриц числа получаем от пользователя
            int number1 = (int)numUpDownNumber1.Value;
            int number2 = (int)numUpDownNumber2.Value;
            int number3 = (int)numUpDownNumber3.Value;

            //создание увеличения полей на 10
            try
            {
                triadNumbers = new Triad(number1, number2, number3);//создание объекта класса

                //Вызов метода класса
                triadNumbers.FieldNumber(10);

                txtNumberPlus10.Text = string.Format("{0} {1} {2}", triadNumbers.Number1, triadNumbers.Number2, triadNumbers.Number3);//выводим ответ в текстовое поле 

            }
            //Обрабатывам исключение(орицательные числа)
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message);
            }
        }

        //Получаем значения при открытии формы
        private void Form1_Load(object sender, EventArgs e)
        {
            int number1 = (int)numUpDownNumber1.Value;
            int number2 = (int)numUpDownNumber2.Value;
            int number3 = (int)numUpDownNumber3.Value;
            triadNumbers = new Triad(number1, number2, number3);
        }

        //Кнопка замены 1 поля
        private void btnReplace1_Click(object sender, EventArgs e)
        {

            //создание увеличения полей на 1
            try
            {
                int n1 = Convert.ToInt32(txtReplace1.Text);//число которым будем заменять поле получаем от пользователя 

                triadNumbers.SetParams(n1);//Вызываем метод установки параметров полей

                numUpDownNumber1.Value = n1; //Заменяем поле значением введенным пользователем


            }
            //Обрабатывам исключение(орицательные числа)
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message);
            }
            //Обрабатывам исключение(пустое поле)
            catch
            {
                MessageBox.Show("Введите число");
            }

        }

        //Кнопка замены 1 и 2 поля
        private void btnReplace12_Click(object sender, EventArgs e)
        {
           
            //создание увеличения полей на 1
            try
            {
                //числа которыми будем заменять поля получаем от пользователя 
                int n1 = Convert.ToInt32(txtReplace1.Text);
                int n2 = Convert.ToInt32(txtReplace12.Text);

                triadNumbers.SetParams(n1, n2);//Вызываем метод установки параметров полей

                //Заменяем поля значениями введенными пользователем
                numUpDownNumber1.Value = n1;
                numUpDownNumber2.Value = n2;


            }
            //Обрабатывам исключение(орицательные числа)
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message);
            }
            //Обрабатывам исключение(пустое поле)
            catch
            {
                MessageBox.Show("Введите число");
            }
        }

        //Кнопка замены 1,2 и 3 поля
        private void btnReplace123_Click(object sender, EventArgs e)
        {
            //создание увеличения полей на 1
            try
            {

                //числа которыми будем заменять поля получаем от пользователя 
                int n1 = Convert.ToInt32(txtReplace1.Text);
                int n2 = Convert.ToInt32(txtReplace12.Text);
                int n3 = Convert.ToInt32(txtReplace123.Text);

                triadNumbers.SetParams(n1,n2,n3);//Вызываем метод установки параметров полей

                //Заменяем поля значениями введенными пользователем
                numUpDownNumber1.Value = n1;
                numUpDownNumber2.Value = n2;
                numUpDownNumber3.Value = n3;


            }
            //Обрабатывам исключение(орицательные числа)
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message);
            }
            //Обрабатывам исключение(пустое поле)
            catch
            {
                MessageBox.Show("Введите число");
            }
        }

        //Кнопка о программе
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хужанова Анастасия ИСП-31\n"+
                "Вариант 10\n"+
                "Создать класс Triad (тройка отрицательных чисел).\n"+
                "Создать необходимые методы и свойства.\n "+
               "Определить метод увеличения полей на 1.\n "+
               "Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения всех чисел на 10.\n ");
        }

        //Кнопка Выход
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

   
}


