class Program
{
    static void Main()
    {
        double peso,anos;
        Console.WriteLine("Informe sua idade em anos: ");
        anos = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe seu peso em kg: ");
        peso = double.Parse(Console.ReadLine());
        if (anos >= 12)
        {
            if (peso < 60)
            {
                Console.WriteLine($"Você deve tomar {875 / 500 * 20} gotas.");
            }
            else
            {
                Console.WriteLine($"Você deve tomar {1000 / 500 * 20} gotas.");
            }
        }
        else
        {
           if (peso < 4.9)
            {
                Console.WriteLine($"Você não deve tomar o remédio.");
            }
            else if (peso >= 5.0 && peso <= 9 )
            {
                Console.WriteLine($"Você deve tomar {125 / 500 * 20} gotas.");
            }
            else if (peso >= 9.1 && peso <= 16)
            {
                Console.WriteLine($"Você deve tomar {250 / 500 * 20} gotas.");
            }
            else if (peso >= 16.1 && peso <= 24)
            {
                Console.WriteLine($"Você deve tomar {375 / 500 * 20} gotas.");
            }
            else if (peso >= 24.1 && peso <= 30)
            {
                Console.WriteLine($"Você deve tomar {500 / 500 * 20} gotas.");
            }
            else
            {
                Console.WriteLine($"Você deve tomar {750 / 500 * 20} gotas.");
            }
}}}