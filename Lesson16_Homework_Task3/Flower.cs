using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_Homework_Task3
{
    static class Flower
    {
        public static void Print(string str, int color)
        {
            switch(color)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(str);
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(str);
                        break;
                    }

                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(str);
                        break;
                    }

                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(str);
                        break;
                    }
                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(str);
                        break;
                    }


            }
        }

    }
}
