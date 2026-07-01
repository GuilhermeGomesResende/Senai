class Program {
    static void Main ()
{
    double nota1 = 0;
    double nota2 = 0;
    double nota3 = 0;
    Console.WrideLine(Qual sera suas 3 notas?);
    nota1 = double.Parse(Console.ReadLine());
    nota2 = double.Parse(Console.ReadLine());
    nota3 = double.Parse(Console.ReadLine());
    Console.Write($"A media vai ser; {(nota1*2+nota2*3+nota3*5)/10:F2}");
}

}