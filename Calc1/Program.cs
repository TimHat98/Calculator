using System;

namespace Calc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в мой калькулятор \n");
            Console.WriteLine("Выбирите действие: \n 1 - Сложение \n 2 - Вычитание \n 3 - Умножение \n 4 - Деление \n 5 - Квадратный корень \n 6 - Возведение в степень \n ");
            var input = Console.ReadLine();
            double choice = Convert.ToDouble(input);

            if (choice == 1)
            {
                Console.WriteLine("Введите число 1 \n");
                var num1 = Console.ReadLine();
                double number1 = Convert.ToDouble(num1);
                Console.WriteLine($"Вы ввели: {number1}");
                Console.WriteLine("Введите число 2 \n");
                var num2 = Console.ReadLine();
                double number2 = Convert.ToDouble(num2);          
                Console.WriteLine($"Вы ввели: {number2}");
                double result = Program.Sum(number1, number2);
                Console.WriteLine($"Результат: {number1} + {number2} = {result}");
                Console.ReadKey();
            }

            else if (choice == 2)
            {
                Console.WriteLine("Введите число 1 \n");
                var num1 = Console.ReadLine();
                double number1 = Convert.ToDouble(num1);
                Console.WriteLine($"Вы ввели: {number1}");
                Console.WriteLine("Введите число 2 \n");
                var num2 = Console.ReadLine();
                double number2 = Convert.ToDouble(num2);
                Console.WriteLine($"Вы ввели: {number2}");
                double result = Program.Razn(number1, number2);
                Console.WriteLine($"Результат: {number1} - {number2} = {result}");
                Console.ReadKey();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Введите число 1 \n");
                var num1 = Console.ReadLine();
                double number1 = Convert.ToDouble(num1);
                Console.WriteLine($"Вы ввели: {number1}");
                Console.WriteLine("Введите число 2 \n");
                var num2 = Console.ReadLine();
                double number2 = Convert.ToDouble(num2);
                Console.WriteLine($"Вы ввели: {number2}");
                double result = Program.Umnog(number1, number2);
                Console.WriteLine($"Результат: {number1} * {number2} = {result}");
                Console.ReadKey();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Введите число 1 \n");
                var num1 = Console.ReadLine();
                double number1 = Convert.ToDouble(num1);
                Console.WriteLine($"Вы ввели: {number1}");
                Console.WriteLine("Введите число 2 \n");
                var num2 = Console.ReadLine();
                double number2 = Convert.ToDouble(num2);
                Console.WriteLine($"Вы ввели: {number2}");
                double result = Program.Del(number1, number2);
                Console.WriteLine($"Результат: {number1} / {number2} = {result}");
                Console.ReadKey();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Введите число: \n");
                var numx = Console.ReadLine();
                double numberx = Convert.ToDouble(numx);
                Console.WriteLine($"Вы ввели: {numberx}");
                double result = Program.Koren(numberx);
                Console.WriteLine($"Результат: Корень {numberx} = {result}");
                Console.ReadKey();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Введите число: \n");
                var numx= Console.ReadLine();
                double numberx = Convert.ToDouble(numx);
                Console.WriteLine($"Вы ввели: {numberx}");
                Console.WriteLine("Введите степень:  \n");
                var numy = Console.ReadLine();
                double numbery = Convert.ToDouble(numy);
                Console.WriteLine($"Вы ввели: {numbery}");
                double result = Program.Stepen(numberx, numbery);
                Console.WriteLine($"Результат: {numberx} ^ {numberx} = {result}");
                Console.ReadKey();
            }


        }

        static double Sum(double a, double b)
        {
            double Sum = a + b;
            return Sum;   
        }
        static double Razn(double a, double b)
        {
            double Razn = a - b;
            return Razn;
        }
        static double Umnog(double a, double b)
        {
            double Umnog = a * b;
            return Umnog;
        }
        static double Del(double a, double b)
        {
            double Del = a / b;
            return Del;
        }
        static double Koren(double x)
        {
            double Koren = Math.Sqrt(x);
            return Koren;
        }
        static double Stepen (double x, double y)
        {
            double Stepen = Math.Pow(x, y);
            return Stepen;
        }
    }

}
