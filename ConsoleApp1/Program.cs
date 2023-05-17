﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1 -----------------------------------------------
            /*Console.OutputEncoding = System.Text.Encoding.UTF8;

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
             */

            //task 2 -----------------------------------------------------------
            /*Console.OutputEncoding = System.Text.Encoding.UTF8;
            double num = 0.0;
            double res = 0.0;
            Console.WriteLine("Конвертор одиниць виміру");
            Console.WriteLine("Виберіть одиниці для конвертації(1, 2, 3, 4)");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("УВАГА!!! Дробові числа вводити у форматі (0,00) ");
            Console.ResetColor();

            Console.WriteLine(
                "1) Дюйми -> Сантиметри\n" + "2) Сантиметри -> Дюйми\n" + "3) Фунти -> Кілограми\n" + "4) Кілограми -> Фунти");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    Console.WriteLine("Укажіть кількість дюймів:");
                    num = Convert.ToDouble(Console.ReadLine());
                    res = num * 2.54;
                    Console.WriteLine(num + " in = " + Math.Round(res, 2) + " cm");
                    break;

                case "2":
                    Console.WriteLine("Укажіть кількість сантиметрів:");
                    num = Convert.ToDouble(Console.ReadLine());
                    res = num / 2.54;
                    Console.WriteLine(num + " cm = " + Math.Round(res, 2) + " in");
                    break;
                case "3":
                    Console.WriteLine("Укажіть кількість фунтів:");
                    num = Convert.ToDouble(Console.ReadLine());
                    res = num / 2.205;
                    Console.WriteLine(num + " lb = " + Math.Round(res, 3) + " kg");
                    break;
                case "4":
                    Console.WriteLine("Укажіть кількість кілограмів:");
                    num = Convert.ToDouble(Console.ReadLine());
                    res = num * 2.205;
                    Console.WriteLine(num + " lg = " + Math.Round(res, 3) + " lb");
                    break;
                default: 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помилка, виберіть правильний пункт!");
                    Console.ResetColor();
                    break;
            }
            Console.ReadLine();*/

            //task 3 ------------------------------------------------------------------

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Калькуляьор v1.0");
            bool abs = false;

            Console.WriteLine("Чи використовувати значення по модулю? (Y/N)");
            string absUserChose = Console.ReadLine();
            if (absUserChose == "Y" || absUserChose == "y") {
                abs = true;
            } else if (absUserChose == "N" || absUserChose == "n") {
                abs = false;
            } else {
                Console.WriteLine("Введіть тільки Y/N");
                Thread.Sleep(2000);
                return;
            }
            Console.WriteLine("Яку операцію Ви хочете виконати? (1-7)");
            Console.WriteLine("1) Додавання\n" + "2) Віднімання\n" + "3) Множення\n" + "4) Ділення\n" + "5) Корінь числа\n" + "6) Приведення в степінь\n" + "7) Відсоток від числа\n");
            string operStr = Console.ReadLine();

            Console.WriteLine("Увага! Якщо ви використовуєте числа з плаваючою точкою то пішіть її в виді 0,00");
            double a, b, res = 0;
            if (abs == false)
            {
                switch (operStr)
                {
                    case "1":
                        Console.WriteLine("a + b = result");
                        Console.WriteLine("Введіть число а:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введіть число b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        res = a + b;
                        Console.WriteLine("Ви зробили операцію додавання");
                        Console.WriteLine(a + " + " + b + " = " + res);
                        break;
                    case "2":
                        Console.WriteLine("a - b = result");
                        Console.WriteLine("Введіть число а:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введіть число b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        res = a - b;
                        Console.WriteLine("Ви зробили операцію віднімання");
                        Console.WriteLine(a + " - " + b + " = " + res);
                        break;
                    case "3":
                        Console.WriteLine("a * b = result");
                        Console.WriteLine("Введіть число а:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введіть число b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        res = a * b;
                        Console.WriteLine("Ви зробили операцію множення");
                        Console.WriteLine(a + " * " + b + " = " + res);
                        break;
                    case "4":
                        Console.WriteLine("a / b = result");
                        Console.WriteLine("Введіть число а:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введіть число b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        res = a / b;
                        Console.WriteLine("Ви зробили операцію ділення");
                        Console.WriteLine(a + " / " + b + " = " + res);
                        break;
                    case "5":
                        Console.WriteLine("Корінь від а = result");
                        Console.WriteLine("Введіть число а:");
                        a = Convert.ToDouble(Console.ReadLine());
                        res = Math.Sqrt(a);
                        Console.WriteLine("Ви зробили операцію підведення до кореня");
                        Console.WriteLine("sqrt(" + a + ")" + " = " + res);
                        break;
                    case "6":
                        Console.WriteLine("а^b = result");
                        Console.WriteLine("Введіть число а:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введіть число b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        res = Math.Pow(a, b);
                        Console.WriteLine("Ви зробили операцію підведення до степеня");
                        Console.WriteLine(a + "^" + b + " = " + res);
                        break;
                    case "7":
                        Console.WriteLine("a*(b/100) = result");
                        Console.WriteLine("Введіть число а (Число від якого знайти відсоток):");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введіть число b (Відсоток від числа а):");
                        b = Convert.ToDouble(Console.ReadLine());
                        res = (b/100)*a;
                        Console.WriteLine("Ви зробили операцію знаходження відсотка від числа");
                        Console.WriteLine(a + "*" + "(" + b + " / " + "100)" + " = " + res);
                        break;
                    default:
                        Console.WriteLine("Виберіть ТІЛЬКИ 1-7");
                        break;
                }
            } else
            {
                switch (operStr)
                {
                    case "1":
                        Console.WriteLine("|a| + |b| = result");
                        Console.WriteLine("Введіть число а:");
                        a = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Введіть число b:");
                        b = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        res = a + b;
                        Console.WriteLine("Ви зробили операцію додавання");
                        Console.WriteLine(a + " + " + b + " = " + res);
                        break;
                    case "2":
                        Console.WriteLine("a - b = result");
                        Console.WriteLine("Введіть число а:");
                        a = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Введіть число b:");
                        b = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        res = a - b;
                        Console.WriteLine("Ви зробили операцію віднімання");
                        Console.WriteLine(a + " - " + b + " = " + res);
                        break;
                    case "3":
                        Console.WriteLine("a * b = result");
                        Console.WriteLine("Введіть число а:");
                        a = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Введіть число b:");
                        b = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        res = a * b;
                        Console.WriteLine("Ви зробили операцію множення");
                        Console.WriteLine(a + " * " + b + " = " + res);
                        break;
                    case "4":
                        Console.WriteLine("a / b = result");
                        Console.WriteLine("Введіть число а:");
                        a = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Введіть число b:");
                        b = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        res = a / b;
                        Console.WriteLine("Ви зробили операцію ділення");
                        Console.WriteLine(a + " / " + b + " = " + res);
                        break;
                    case "5":
                        Console.WriteLine("Корінь від а = result");
                        Console.WriteLine("Введіть число а:");
                        a = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        res = Math.Sqrt(a);
                        Console.WriteLine("Ви зробили операцію підведення до кореня");
                        Console.WriteLine("sqrt(" + a + ")" + " = " + res);
                        break;
                    case "6":
                        Console.WriteLine("а^b = result");
                        Console.WriteLine("Введіть число а:");
                        a = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Введіть число b:");
                        b = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        res = Math.Pow(a, b);
                        Console.WriteLine("Ви зробили операцію підведення до степеня");
                        Console.WriteLine(a + "^" + b + " = " + res);
                        break;
                    case "7":
                        Console.WriteLine("a*(b/100) = result");
                        Console.WriteLine("Введіть число а (Число від якого знайти відсоток):");
                        a = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        Console.WriteLine("Введіть число b (Відсоток від числа а):");
                        b = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                        res = (b / 100) * a;
                        Console.WriteLine("Ви зробили операцію знаходження відсотка від числа");
                        Console.WriteLine(a + "*" + "(" + b + " / " + "100)" + " = " + res);
                        break;
                    default:
                        Console.WriteLine("Виберіть ТІЛЬКИ 1-7");
                        break;
                } 
            }

            Console.ReadLine();
        }
    }
}
