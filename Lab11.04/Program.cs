using System;

interface IMath
{
    double Sum(double a, double b);
    double Sub(double a, double b);
    double Mul(double a, double b); 
    double Div(double a, double b);
}

class Program
{
    delegate double MathOperation(double a, double b);

    static void Main(string[] args)
    {
        IMath math = new Math();

        MathOperation sum = math.Sum;
        MathOperation sub = math.Sub;
        MathOperation mul = math.Mul;
        MathOperation div = math.Div;

        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите первое число:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double b = Convert.ToDouble(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine(sum(a, b));
                break;
            case 2:
                Console.WriteLine(sub(a, b));
                break;
            case 3:
                Console.WriteLine(mul(a, b));
                break;
            case 4:
                Console.WriteLine(div(a, b));
                break;
            default:
                Console.WriteLine("Нет такой команды");
                break;
        }

        Console.ReadLine();
    }
}

class Math : IMath
{
    public double Sum(double a, double b)
    {
        return a + b;
    }

    public double Sub(double a, double b)
    {
        return a - b;
    }

    public double Mul(double a, double b)
    {
        return a * b;
    }

    public double Div(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Делить на 0 нельзя");
        }
        return a / b;
    }
}
