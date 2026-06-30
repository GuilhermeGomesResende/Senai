class Program
{
    static void Main()
    {
        double numero = 0;
        Console.Write("digite o valor da velocidade em m/s que voce quer converter para km/h : ");
        numero = double.Parse(Console.ReadLine());
        Console.Write($"o valor da velocidade convertida em km/h é : {numero*3.6}");
    }
}