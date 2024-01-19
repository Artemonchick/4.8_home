using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 2 из практической работы 3

            Console.Clear();
            Console.WriteLine("Игра \"21\"");

            Console.Write("Введите имя игрока: ");
            string name = Console.ReadLine();

            Console.Write($"Добро пожаловать в игру, {name}! \nВведите количество ваших карт: ");
            int summCard = Convert.ToInt32(Console.ReadLine());

            int num;
            int summ = 0;

            for (int i = 1; i <= summCard; i++)
            {
                Console.Write($"Введите номинал {i}-й карты: ");

                string pic = Console.ReadLine();

                switch (pic)
                {
                    case "J":
                        {
                            summ = summ + 10;
                            break;
                        }
                    case "K":
                        {
                            summ = summ + 10;
                            break;
                        }
                    case "Q":
                        {
                            summ = summ + 10;
                            break;
                        }
                    case "T":
                        {
                            summ = summ + 10;
                            break;
                        }
                    default:
                        {
                            num = int.Parse(pic);
                            summ = summ + num;
                            break;
                        }

                }
            }

            Console.WriteLine($"Сумма ваших карт равна: {summ} ");
            Console.ReadKey();

            #endregion
        }
    }
}
