using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class E
    {
        public void showText(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(text);

            Console.WriteLine();
        }
        public void TaskOne() {
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
            }
            else if (imt < 25 && imt > 18.5)
            {
                Console.WriteLine("Ви молодець, Ваша вага в нормі!");
            }
            else
            {
                Console.WriteLine("Велика надмірна вага! Вам треба худнути! Полюбіть себе, життя чудове!");
            }
            Console.ReadLine();
        }
        //---------------------------two--------------------------
        public void TaskTwo() {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
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
            switch (choice)
            {
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
            Console.ReadLine();
        }

        //----------------------three----------------------------------
        public void TaskThree()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Калькуляьор v1.0");
            bool abs = false;
            string a, b = "";
            double res, doubleA, doubleB = 0;
            void enterAndSaving()
            {
                Console.WriteLine("Введіть число а:");
                a = Console.ReadLine();
                Console.WriteLine("Введіть число b:");
                b = Console.ReadLine();
            }
            Console.WriteLine("Чи використовувати значення по модулю? (Y/N)");
            string absUserChose = Console.ReadLine();
            if (absUserChose == "Y" || absUserChose == "y")
            {
                abs = true;
            }
            else if (absUserChose == "N" || absUserChose == "n")
            {
                abs = false;
            }
            else
            {
                Console.WriteLine("Введіть тільки Y/N");
                Thread.Sleep(2000);
                return;
            }
            Console.WriteLine("Яку операцію Ви хочете виконати? (1-7)");
            Console.WriteLine("1) Додавання\n" + "2) Віднімання\n" + "3) Множення\n" + "4) Ділення\n" + "5) Корінь числа\n" + "6) Приведення в степінь\n" + "7) Відсоток від числа\n");

            string operStr = Console.ReadLine();

            Console.WriteLine("Увага! Якщо ви використовуєте числа з плаваючою точкою то пішіть її в виді 0,00");

            if (abs == false)
            {
                switch (operStr)
                {
                    case "1":
                        Console.WriteLine("a + b = result");
                        enterAndSaving();

                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {
                            res = doubleA + doubleB;
                            Console.WriteLine("Ви зробили операцію додавання");
                            Console.WriteLine($"{doubleA} + {doubleB} = {res}");
                        } else { Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0"); }
                        break;
                    case "2":
                        Console.WriteLine("a - b = result");
                        enterAndSaving();
                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {
                            res = doubleA - doubleB;
                            Console.WriteLine("Ви зробили операцію віднімання");
                            Console.WriteLine($"{doubleA} - {doubleB} = {res}");
                        } else { Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0"); }
                        break;
                    case "3":
                        Console.WriteLine("a * b = result");
                        enterAndSaving();
                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {
                            res = doubleA * doubleB;
                            Console.WriteLine("Ви зробили операцію множення");
                            Console.WriteLine($"{doubleA} * {doubleB} = {res}");
                        } else {Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0");}

                        break;
                    case "4":
                        Console.WriteLine("a / b = result");
                        enterAndSaving();
                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {
                            if (doubleB == 0)
                            {
                                Console.WriteLine("Ділення на 0 неможливе!");
                                return;
                            }
                            res = doubleA / doubleB;
                            Console.WriteLine("Ви зробили операцію ділення");
                            Console.WriteLine($"{doubleA} / {doubleB} = {res}");
                        } else {Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0");}
                        
                        break;
                    case "5":
                        Console.WriteLine("Корінь від а = result");
                        Console.WriteLine("Введіть число а:");
                        a = Console.ReadLine();
                        if (Double.TryParse(a, out doubleA))
                        {
                            if (doubleA < 0)
                            {
                                Console.WriteLine("Неможливо знайти корінь від від'ємного числа");
                            }
                            res = Math.Sqrt(doubleA);
                            Console.WriteLine("Ви зробили операцію підведення до кореня");
                            Console.WriteLine($"sqrt({doubleA}) = {res}");
                        } else {Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0");}
                        break;
                    case "6":
                        Console.WriteLine("а^b = result");
                        enterAndSaving();
                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {
                            res = Math.Pow(doubleA, doubleB);
                            Console.WriteLine("Ви зробили операцію підведення до степеня");
                            Console.WriteLine($"{doubleA} ^ {doubleB} = {res}");
                        } else {Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0");}
                        break;
                    case "7":
                        Console.WriteLine("a*(b/100) = result");
                        Console.WriteLine("Введіть число а (Число від якого знайти відсоток):");
                        a = Console.ReadLine();
                        Console.WriteLine("Введіть число b (Відсоток від числа а):");
                        b = Console.ReadLine();
                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {
                            res = (doubleB / 100) * doubleA;
                            Console.WriteLine("Ви зробили операцію знаходження відсотка від числа");
                            Console.WriteLine($"{doubleA} * ({doubleB} / 100) = {res}");
                        }
                        else {Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0");}
                        break;
                    default: Console.WriteLine("Виберіть ТІЛЬКИ 1-7"); break;
                }
            }
            else
            {
                switch (operStr)
                {
                    case "1":
                        Console.WriteLine("|a| + |b| = result");
                        enterAndSaving();
                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {
                            res = Math.Abs(doubleA) + Math.Abs(doubleB);
                            Console.WriteLine("Ви зробили операцію додавання");
                            Console.WriteLine($"|{doubleA}| + |{doubleB}| = {res}");
                        }
                        else { Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0"); }
                        break;
                    case "2":
                        Console.WriteLine("|a| - |b| = result");
                        enterAndSaving();
                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {
                            res = Math.Abs(doubleA) - Math.Abs(doubleB);
                            Console.WriteLine("Ви зробили операцію віднімання");
                            Console.WriteLine($"|{doubleA}| - |{doubleB}| = {res}");
                        }
                        else { Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0"); }
                        break;
                    case "3":
                        Console.WriteLine("|a| * |b| = result");
                        enterAndSaving();
                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {
                            res = Math.Abs(doubleA) * Math.Abs(doubleB);
                            Console.WriteLine("Ви зробили операцію множення");
                            Console.WriteLine($"|{doubleA}| * |{doubleB}| = {res}");
                        }
                        else { Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0"); }
                        break;
                    case "4":
                        Console.WriteLine("|a| / |b| = result");
                        enterAndSaving();
                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {   
                            if (doubleB == 0)
                            {
                                Console.WriteLine("Ділення на 0 неможливе!");
                                return;
                            }
                            res = Math.Abs(doubleA) / Math.Abs(doubleB);
                            Console.WriteLine("Ви зробили операцію ділення");
                            Console.WriteLine($"|{doubleA}| / |{doubleB}| = {res}");
                        }
                        else { Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0"); }
                        break;
                    case "5":
                        Console.WriteLine("Корінь від |а| = result");
                        Console.WriteLine("Введіть число а:");
                        a = Console.ReadLine();
                        if (Double.TryParse(a, out doubleA))
                        {
                            res = Math.Sqrt(Math.Abs(doubleA));
                            Console.WriteLine("Ви зробили операцію підведення до кореня");
                            Console.WriteLine($"sqrt(|{doubleA}|) = {res}");
                        }
                        else { Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0"); }
                        break;
                    case "6":
                        Console.WriteLine("|а|^|b| = result");
                        enterAndSaving();
                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {
                            res = Math.Pow(Math.Abs(doubleA), Math.Abs(doubleB));
                            Console.WriteLine("Ви зробили операцію підведення до степеня");
                            Console.WriteLine($"|{doubleA}| ^ |{doubleB}| = {res}");
                        }
                        else { Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0"); }
                        break;
                    case "7":
                        Console.WriteLine("|a|*(|b|/100) = result");
                        enterAndSaving();
                        if (Double.TryParse(a, out doubleA) && Double.TryParse(b, out doubleB))
                        {
                            res = (Math.Abs(doubleB)/ 100) * Math.Abs(doubleA);
                            Console.WriteLine("Ви зробили операцію знаходження відсотка від числа");
                            Console.WriteLine($"|{doubleA}| * (|{doubleB}| / 100) = {res}");
                        }
                        else { Console.WriteLine("Введить числа ТІЛЬКИ в фортаті 0,00 або 0"); }
                        break;
                    default:
                        Console.WriteLine("Виберіть ТІЛЬКИ 1-7");
                        break;
                }
            }

            Console.ReadLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            E e = new E();

            e.showText("Виберіть завдання:", ConsoleColor.White);
            e.showText("[1] Завдання №1", ConsoleColor.Cyan);
            e.showText("[2] Завдання №2", ConsoleColor.Green);
            e.showText("[3] Завдання №3", ConsoleColor.Yellow);
            int menuM = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); Console.ResetColor();

            switch (menuM)
            {
                case 1:
                    e.TaskOne();
                    break;
                case 2:
                    e.TaskTwo();
                    break;
                case 3:
                    e.TaskThree();
                    break;
                default:
                    e.showText("Виберіть завдання:", ConsoleColor.White);
                    e.showText("[1] Завдання №1", ConsoleColor.Cyan);
                    e.showText("[2] Завдання №2", ConsoleColor.Green);
                    e.showText("[3] Завдання №3", ConsoleColor.Yellow);
                    menuM = Convert.ToInt32(Console.ReadLine());


                    Console.Clear();
                    break;
            }
            Console.ReadLine();
        }
    }
}
