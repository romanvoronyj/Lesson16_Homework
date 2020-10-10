using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Homework_Task4
{
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            switch(worker)
            {
                case Post.Logistician:
                    {
                        if(hours > 250)
                        {
                            Console.WriteLine("Потрібно нарахувати премію.");
                        }
                        else
                        {
                            Console.WriteLine("Премія не передбачена.");
                        }
                        break;
                   }
                case Post.Accaccountant:
                    {
                        if (hours > 220)
                        {
                            Console.WriteLine("Потрібно нарахувати премію.");
                        }
                        else
                        {
                            Console.WriteLine("Премія не передбачена.");
                        }
                        break;
                    }

                case Post.HR:
                    {
                        if (hours > 200)
                        {
                            Console.WriteLine("Потрібно нарахувати премію.");
                        }
                        else
                        {
                            Console.WriteLine("Премія не передбачена.");
                        }
                        break;
                    }
                case Post.PurchasingManager:
                    {
                        if (hours > 230)
                        {
                            Console.WriteLine("Потрібно нарахувати премію.");
                        }
                        else
                        {
                            Console.WriteLine("Премія не передбачена.");
                        }
                        break;
                    }
            }
            return false;

        }
    }
}
