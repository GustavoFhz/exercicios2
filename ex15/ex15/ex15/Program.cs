namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os 3 lados de um triangulo");
            var l1 = double.Parse(Console.ReadLine());
            var l2 = double.Parse(Console.ReadLine());
            var l3 = double.Parse(Console.ReadLine());

           if (l1 + l2 > l3 ) {
                bool triangulo = true;
                Console.WriteLine("Os Lados informados formam um triangulo do tipo:");
            }

            if(l1 == l2 && l1 == l3 && l2 == l3)
            {
                Console.WriteLine("Triângulo Equilátero");
            } 
            else if(l1 == l2 || l1 == l3 || l2 == l3)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else if(l1 != l2 && l1 != l3 && l2 !=l3)
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
    }
}