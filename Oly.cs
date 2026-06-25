using System;
class Oly
{
    static void Main()
    {
        double numero = 0;
    Console.Write("digite um numero:");
    numero = double.Parse(Console.ReadLine());
    Console.Write($"o valor de {numero} com um reajuste de 10% é: {numero*0.10}");
    
    }
}