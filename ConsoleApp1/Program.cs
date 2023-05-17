using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double imt = 0;

            Console.WriteLine("Напишіть свою вагу(кг)");
            double weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Напишіть свій зріст(см)");
            double height = Convert.ToInt32(Console.ReadLine());

            double heightM = height / 100;
            imt = weight / (heightM * heightM);
            Console.WriteLine("Ваш ІМТ: " + Math.Round(imt, 2));

            if (imt < 18.9)
            {
                Console.WriteLine("Вам слід набрати вагу! Вага недостатня, щоб бути здоровим!");
            } else if (imt < 25 && imt > 18.5)
            {
                Console.WriteLine("Ви молодець, Ваша вага в нормі!");
            } else
            {
                Console.WriteLine("Велика надмірна вага! Вам треба худнути! Полюбіть себе, життя чудове!");
            }

            Console.ReadLine();
        }
    }
}
