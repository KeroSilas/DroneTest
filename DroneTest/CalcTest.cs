namespace DroneTest;

public class Tests
{
    Calc calc;
    
    [SetUp]
    public void Setup()
    {
        calc = new Calc();
    }

    [Test]
    public void TestAdd()
    {
        Assert.That(calc.Add(2, 3), Is.EqualTo(5));
    }
    
    [Test]
    public void TestSubtract()
    {
        Assert.That(calc.Subtract(5, 3), Is.EqualTo(2));
    }
    
    [Test]
    public void TestMultiply()
    {
        Assert.That(calc.Multiply(2, 3), Is.EqualTo(6));
    }
    
    [Test]
    public void TestDivide()
    {
        Assert.That(calc.Divide(6, 3), Is.EqualTo(2));
    }
    
    [Test]
    public void TestModulo()
    {
        Assert.That(calc.Modulo(5, 3), Is.EqualTo(2));
    }
    
    [Test]
    public void TestPower()
    {
        Assert.That(calc.Power(2, 3), Is.EqualTo(8));
    }
    
    [Test]
    public void TestFactorial()
    {
        Assert.That(calc.Factorial(5), Is.EqualTo(120));
    }
    
    [Test]
    public void TestFactorialZero()
    {
        Assert.That(calc.Factorial(0), Is.EqualTo(1));
    }
    
    [Test]
    public void TestFactorialOne()
    {
        Assert.That(calc.Factorial(1), Is.EqualTo(1));
    }
}