namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a nota 1:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota 2:");
            double n2 = double.Parse(Console.ReadLine());

            var media = (n1 + n2) / 2;

            var conceito = "";

            if(media >= 9 && media <= 10)
            {
                conceito = "A";
                Console.WriteLine($"Conceito {conceito}");
            }
            else if(media >= 7.5 && media <= 9)
            {
                conceito = "B";
                Console.WriteLine($"Conceito {conceito}");
            }
            else if(media >= 6 && media <= 7.5)
            {
                conceito = "C";
                Console.WriteLine($"Conceito {conceito}");
            }
            else if(media >= 4 && media <= 6)
            {
                conceito = "D";
                Console.WriteLine($"Conceito {conceito}");
            }
            else if(media <= 4)
            {
                conceito = "E";
                Console.WriteLine($"Conceito {conceito}");
            }

            switch (conceito)
            {
                case "A":
                    Console.WriteLine("Aprovado"); break;
                    case "B":
                    Console.WriteLine("Aprovado"); break;
                case "C":
                    Console.WriteLine("Aprovado"); break;
                    case "D":
                    Console.WriteLine("Reprovado"); break;
                case "E":
                    Console.WriteLine("Reprovado"); break;
                default:
                    Console.WriteLine("Invalido"); break;
            }
            

            Console.WriteLine($"Nota 1 é igual a {n1}");
            Console.WriteLine($"Nota 2 é igual a {n2}");
            Console.WriteLine($"A sua média foi de {media}");
        }
    }
}