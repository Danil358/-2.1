public class Calculator
{
    private int Add(int a, int b)
    {
        return a + b;
    }

    public double Subtract(double a, double b) 
    {
        return a - b;
    }

    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        double resultSubtraction = calc.Subtract(3, 4);
        Console.WriteLine($"Результат вычитания: {resultSubtraction}");
        int resultAddition = calc.AddNumbers(5, 7); 
        Console.WriteLine($"Результат сложения: {resultAddition}");
    }
    public int AddNumbers(int a, int b)
    {
        return this.Add(a, b);
    }
}

