/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой, создайте класс Calculator. В теле класса создайте четыре
метода для арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div
– деление). Метод деления должен делать проверку деления на ноль, если проверка не
проходит, сгенерировать исключение. Пользователь вводит значения, над которыми хочет
произвести операцию и выбрать саму операцию. При возникновении ошибок должны
выбрасываться исключения.
*/

Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите знак арифметической операции:");
string sign = Console.ReadLine();

switch (sign)
{
    case "+":
        Calculator.Add(a, b);
        break;
    case "-":
        Calculator.Sub(a, b);
        break;
    case "*":
        Calculator.Mul(a, b);
        break;
    case "/":
        Calculator.Div(a, b);
        break;
    default: Console.WriteLine("Операция не определена");
        break;
}
Console.ReadKey();

static class Calculator
{
    public static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public static void Sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    public static void Mul(int a, int b)
    {
        Console.WriteLine(a * b);
    }
    public static void Div(int a, int b)
    {
     try
     {
        Console.WriteLine((float)(a / b));
     }
    catch (DivideByZeroException)
     {
        Console.WriteLine("Возникло исключение DivideByZeroException: на ноль делить нельзя!");
     }
    }
}