namespace DroneTest;

public class Calc
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    
    public int Divide(int a, int b)
    {
        return a / b;
    }
    
    public int Modulo(int a, int b)
    {
        return a % b;
    }
    
    public int Power(int a, int b)
    {
        return (int)Math.Pow(a, b);
    }
    
    public int Factorial(int a)
    {
        if (a == 0)
        {
            return 1;
        }
        else
        {
            return a * Factorial(a - 1);
        }
    }
}