using System;

namespace Calc1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Добро пожаловать в мой калькулятор \n");
            Console.WriteLine("Выбирите действие: \n 1 - Сложение \n 2 - Вычитание \n 3 - Умножение \n 4 - Деление \n 5 - Квадратный корень \n 6 - Возведение в степень \n ");

            var input = Console.ReadLine();
            double choice = Convert.ToDouble(input);
            if (choice == 5)
            {
                Console.WriteLine("Введите число: \n");
                var numx = Console.ReadLine();
                var number = Convert.ToDouble(numx);
                Console.WriteLine($"Вы ввели: {number}");
                ChoiceExecute(choice, numberx: number);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Введите число 1 \n");
                var num1 = Console.ReadLine();
                var number1 = Convert.ToDouble(num1);
                Console.WriteLine($"Вы ввели: {number1}");
                Console.WriteLine("Введите число 2 \n");
                var num2 = Console.ReadLine();
                var number2 = Convert.ToDouble(num2);
                Console.WriteLine($"Вы ввели: {number2}");
                ChoiceExecute(choice, number1, number2);
                Console.ReadKey();
            }
        }

        static void ChoiceExecute (double choice, double number1 = 0, double number2 = 0, double numberx = 0)
        {
            switch (choice)
            {
                case 1:
                    var result =  Program.Sum(number1, number2);
                    Console.WriteLine($"Результат: {number1} + {number2} = {result}");
                    return;
                case 2:
                    var result2 = Program.Diff(number1, number2);
                    Console.WriteLine(value: $"Результат: {number1} - {number2} = {result2}");
                    return;
                case 3:
                    var result3 = Program.Mult(number1, number2);
                    Console.WriteLine(value: $"Результат: {number1} * {number2} = {result3}");
                    return;
                case 4:
                    var result4 = Program.Div(number1, number2);
                    Console.WriteLine(value: $"Результат: {number1} / {number2} = {result4}");
                    return;
                case 5:
                    var result5 = Program.SqrtOfNumber(numberx);
                    Console.WriteLine(value: $"Результат: Квадратный корень {numberx} = {result5}");
                    return;
                case 6:
                    var result6 = Program.PowOfNumber(number1, number2);
                    Console.WriteLine(value: $"Результат: {number1} ^ {number2} = {result6}");
                    return;
                default:
                    Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                    var again = Convert.ToChar(Console.ReadLine());
                    break;

            }
        }

        static double Sum(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        static double Diff(double a, double b)
        {
            double diff = a - b;
            return diff;
        }
        static double Mult(double a, double b)
        {
            double mult = a * b;
            return mult;
        }
        static double Div(double a, double b)
        {
            double div = a / b;
            return div;
        }
        static double SqrtOfNumber(double x)
        {
            double sqrt = Math.Sqrt(x);
            return sqrt;
        }
        static double PowOfNumber(double y, double z)
        {
            double pow = Math.Pow(y, z);
            return pow;
        }
    }
}
