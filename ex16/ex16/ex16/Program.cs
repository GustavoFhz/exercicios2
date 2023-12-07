using static System.Net.Mime.MediaTypeNames;

namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de A, B, C para calcular a equação de 2° grau");

            Console.WriteLine("Digite o coeficiente de A:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o coeficiente de B:");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o coeficiente de C:");
            var c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Finalizando o programa, pois a = 0");
                System.Environment.Exit(1);
            }

            // ax^2 + bx + c = 0
            // Delta = b^2 - 4ac
            // x = -b =- Vdelta / 2*a

            var delta = b * b - 4 * a * c;
            
            double x1 , x2 ;

            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        

            if(delta < 0)
            {
                Console.WriteLine("A equação não possui raizes reais");
                Environment.ExitCode = 0;
            }

            if(delta == 0)
            {
                Console.WriteLine("A equação possui apenas uma raiz real");
            } 
            else if( delta > 0)
            {
                Console.WriteLine($"A equação possui duas raizes reais {x1} e {x2}");
            }

            
        }
    }
}