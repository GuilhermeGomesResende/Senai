class Program
{
    static void Main()
    {
    double numero = 0;
    Console.Write("digite uma temperatura em fahrenheit : ");
    numero = double.Parse(Console.ReadLine());
    Console.Write($"a temperatura {numero}F em celsius corresponde a : {(numero-32)*5/9}C");
    }
}
