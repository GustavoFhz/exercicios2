namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor 1");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor 2");
            double valor2 = double.Parse(Console.ReadLine());

            if(valor1 > valor2) {
                Console.WriteLine($"O maior valor é o {valor1}");
            }
            else
                Console.WriteLine($"O maior valor é o {valor2}");
        }
    }
}