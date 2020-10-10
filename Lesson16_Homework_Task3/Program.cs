using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Homework_Task3
{
    /*Створіть статичний клас з методом voidPrint (stringstr, intcolor), який виводить на екран рядок заданим кольором. 
     * Використовуючи перерахування, створіть набір квітів, доступних користувачеві. Введення рядка і вибір кольору надайте користувачеві.
     */

    enum Colors
    {
        None,
        Yellow,
        Magenta,
        Red,
        White,
        DarkBlue
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть назву квітів:");
            string myStr = Console.ReadLine();

            Console.WriteLine($"Оберіть доступний колір:\t1 - {Colors.Yellow}\t2 - {Colors.Magenta}\t3 - {Colors.Red}\t4 - {Colors.White}\t5 - {Colors.DarkBlue}");
            int colorNumber = Int32.Parse(Console.ReadLine());

            Flower.Print(myStr, colorNumber);

            Console.ReadKey();
        }
    }
}
