using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Homework_Task1
{
    /*Завдання 1
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Реалізуйте програму, яка буде приймати від користувача дату його народження і виводити кількість днів до його наступного дня народження.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть дату народження: ");

            DateTime myBirthDay = new DateTime();
            myBirthDay = DateTime.Parse(Console.ReadLine());
            TimeSpan left = myBirthDay - (DateTime.Now);
            double daysLeft = left.TotalDays;
            Console.WriteLine("До дня наступного Дня Народження залишилось : {0:dd}", left);

            Console.ReadKey();
        }
    }
}
