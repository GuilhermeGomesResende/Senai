class Program
{
    static void Main()
    {
        double s,p;
        Console.WriteLine("Digite seu salário: ");
        s = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da prestação: ");
        p = double.Parse(Console.ReadLine());
        if ( p > s * 0.2)
        {
            Console.Write("O salário não pode ser concedido");
        }
        else
        {
            Console.Write("O salário pode ser concedido");
        }
        }}