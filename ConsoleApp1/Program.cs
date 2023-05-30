using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    static class MessageHelper
    {
        // Input Helpers
        static public string getString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        static public double getDouble(string message)
        {
            try
            {
                return double.Parse(MessageHelper.getString(message));
            }
            catch
            {
                Console.WriteLine("Please enter valid number only");
                Thread.Sleep(1000);
                System.Environment.Exit(1);
                return 0;
            }
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Calculator v2.0.0");
            double firstNum, secondNum = 0;
            string operation;

            firstNum = MessageHelper.getDouble("Enter first number:");
            operation = MessageHelper.getString("Enter operation (+, -, *, /):");
            if (operation != "+" && operation != "-" && operation != "*" && operation != "/") 
            { Console.WriteLine("Enter only +, -, *, /"); Thread.Sleep(1000); return; }
            secondNum = MessageHelper.getDouble("Enter second number:");

            // Output in switch/case helper
            void taskDoing(string operationName, char oper)
            {
                Console.WriteLine($"Now you are doing {operationName} oreration.");
                double result = 0;
                switch (oper)
                {
                    case '+':
                        result = firstNum + secondNum;
                        break;
                    case '-':
                        result = firstNum - secondNum;
                        break;
                    case '*':
                        result = firstNum * secondNum;
                        break;
                    case '/':
                        if (secondNum == 0)
                        { Console.WriteLine("Division by 0 is not impossible"); return; }
                        result = firstNum / secondNum;
                        break;
                }

                Console.WriteLine($"{firstNum} {oper} {secondNum} = {result}");

            }

            switch (operation)
            {
                case "+":
                    taskDoing("addition", '+');
                    break;
                case "-":
                    taskDoing("subtraction", '-');
                    break;
                case "*":
                    taskDoing("multiplication", '*');
                    break;
                case "/":
                    taskDoing("division", '/');
                    break;
            }

            Console.ReadLine();
        }
    }
}
