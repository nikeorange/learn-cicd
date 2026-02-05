namespace SimpleApp;

public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Multiply(int a, int b) => a * b;
}

class Program
{
    static void Main()
    {
        var calc = new Calculator();
        Console.WriteLine("=== Simple App ===");
        Console.WriteLine($"2 + 3 = {calc.Add(2, 3)}");
        Console.WriteLine($"2 * 3 = {calc.Multiply(2, 3)}");
        Console.WriteLine("App is working!");
    }
}