using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            int z;
            string x, y;
            Console.WriteLine("Введите целое числов а");
            x = Console.ReadLine();
            Console.WriteLine("Введите целое числов b");
            y = Console.ReadLine();
            try
            {
                int a = Convert.ToInt32(x);
                int b = Convert.ToInt32(y);
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1- сложение");
                Console.WriteLine("2- вычитание");
                Console.WriteLine("3- произведение");
                Console.WriteLine("4- частное");
                Console.WriteLine("Ваш выбоор: {0}", z = Convert.ToInt32(Console.ReadLine()));
                if (z == 1)
                {
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                }
                else
                {
                    if (z == 2)
                    {
                        Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    }
                    else
                    {
                        if (z == 3)
                        {
                            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                        }
                        else
                        {
                            if (z == 4)
                            {
                                try
                                {
                                    Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("нет операции с указанным номером");
                            }
                        }
                    }
                }
            }
            catch (Exception exa)
            {
                Console.WriteLine(exa.Message);
            }

            Console.ReadLine();
        }
    }
}

