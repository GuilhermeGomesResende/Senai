class Program{
    static void Main(){
        double salario = 0;

        Console.Write("Qual o seu salario atual?");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual o seu cargo?");
            Console.WriteLine("101 - Gerente");
                Console.WriteLine("102 - Engenheiro");
                    Console.WriteLine("103 - Tecnico");
                        Console.WriteLine("104 - Outro");
        string codigo = Console.ReadLine();

        switch (codigo) 
        {
            case "101":
            case "1":
                Console.WriteLine($"Seu salario antigo era: {salario}");
                Console.WriteLine($"Seu salario atual será: {salario*1.10}");
                Console.WriteLine($"O aumento foi de:{salario*0.10}");
            break;

            case "102":
            case "2":
                Console.WriteLine($"Seu salario antigo era: {salario}");
                Console.WriteLine($"Seu salario atual será: {salario*1.20}");
                Console.WriteLine($"O aumento foi de:{salario*0.20}");
            break;

            case "103":
            case "3":
                Console.WriteLine($"Seu salario antigo era: {salario}");
                Console.WriteLine($"Seu salario atual será: {salario*1.30}");
                Console.WriteLine($"O aumento foi de: {salario*0.30}");
            break;

            case "104":
            case "4":
                Console.WriteLine($"Seu salario antigo era: {salario}");
                Console.WriteLine($"Seu salario atual será: {salario*1.40}");
                Console.WriteLine($"O aumento foi de: {salario*0.40}");
            break;

            default:
                Console.Write("Codigo invalido");
            break;
        }
         
    }
}