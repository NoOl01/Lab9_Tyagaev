//Lab 9 средний уровень

try
{
    Console.WriteLine("Введите действительную часть комплексного числа (a1):");
    double a1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите мнимую часть комплексного числа (b1):");
    double b1 = Convert.ToDouble(Console.ReadLine());

    ComplexNumber complexNumber = new ComplexNumber(a1, b1);

    double modulus = complexNumber.GetModulus();
    Console.WriteLine($"Модуль комплексного числа: {modulus:F2}");

    ComplexNumber inverseComplexNumber = complexNumber.GetInverse();
    Console.WriteLine("Комплексное число, обратное заданному: " + inverseComplexNumber.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class ComplexNumber
{
    private double real;
    private double imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public double GetModulus()
    {
        return Math.Sqrt(real * real + imaginary * imaginary);
    }

    public ComplexNumber GetInverse()
    {
        double denominator = real * real + imaginary * imaginary;
        double inverseReal = real / denominator;
        double inverseImaginary = -imaginary / denominator;
        return new ComplexNumber(inverseReal, inverseImaginary);
    }
}