﻿
class Atv17
{
    static void Main()
    {
        double i;
        Console.Write("Insira o índice de poluição : ");
        i = double.Parse(Console.ReadLine());
        if (i < 0.25)
        {
            Console.Write("O índice de poluição é aceitável.");
        }
        if (i >= 0.25 && i < 0.4)
        {
            Console.Write("Suspender grupo 1.");
        }
        if (i >= 0.4 && i < 0.5)
        {
            Console.Write("Suspender grupo 1 e 2.");
        }
        if (i > 0.5)
        {
            Console.Write("Suspender todos os grupos.");
        }
        else
        {
            Console.Write("Informação inválida");
        }}}