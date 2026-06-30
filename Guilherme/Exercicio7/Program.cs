class Program{
    static void Main(){
        double x1 = 0;
        double x2 = 0;
        double y1 = 0;
        double y2 = 0;
        Console.Write("Qual o seu x1,x2,y1 e y2: ");
        x1 = double.Parse(Console.ReadLine());
        x2 = double.Parse(Console.ReadLine());
        y1 = double.Parse(Console.ReadLine());
        y2 = double.Parse(Console.ReadLine());
       Console.Write($"resultado igual a = {Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1))}");

    }




}