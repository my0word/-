using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b;
        char oper;

        Console.WriteLine("Добро пожаловать в калькулятор!");

        try
        {
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите оператор (+ или -): ");
            oper = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());

            switch (oper)
            {
                case '+':
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case '-':
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                default:
                    Console.WriteLine("Ошибка: Неправильный оператор. Используйте + или -.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Вводите числа в правильном формате.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}