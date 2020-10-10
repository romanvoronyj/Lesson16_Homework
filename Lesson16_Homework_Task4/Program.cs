using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Homework_Task4
{
    /*Створіть перерахування, в якому будуть міститися посади співробітників як імена констант. Дайте кожній константі значення, 
     що задає кількість годин, які повинен відпрацювати працівник за місяць.
     Створіть клас Accauntant з методом boolAskForBonus (Postworker, inthours), що вирішує давати чи ні співробітнику премію. 
     Якщо співробітник відпрацював більше годин в місяць, то йому належить премія.
     */
     enum Post
    {
        Logistician = 250,
        Accaccountant = 220,
        HR = 200,
        PurchasingManager = 230
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть посаду працівника із доступних:\tLogistician\tAccaccountant\tHR\tPurchasingManager");
            string position = Console.ReadLine();

            Console.WriteLine("Введіть кількість відпрацьованих працівником годин:");
            int workingHours = Int32.Parse(Console.ReadLine());

            Accauntant companyAccauntant = new Accauntant();

            switch(position)
            {
                case "Logistician":
                    {
                        companyAccauntant.AskForBonus(Post.Logistician, workingHours);
                        break;
                    }
                case "Accaccountant":
                    {
                        companyAccauntant.AskForBonus(Post.Accaccountant, workingHours);
                        break;
                    }
                case "HR":
                    {
                        companyAccauntant.AskForBonus(Post.HR, workingHours);
                        break;
                    }

                case "PurchasingManager":
                    {
                        companyAccauntant.AskForBonus(Post.PurchasingManager, workingHours);
                        break;
                    }
 
            }

            Console.ReadKey();
        }
    }
}
