namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número correspondente ao dia da semana (1-Domingo, 2- Segunda, etc.)");
            int day = int.Parse(Console.ReadLine());

            switch(day)
            {
                case 1:
                    Console.WriteLine("Domingo"); break;
                case 2:
                    Console.WriteLine("Segunda"); break;
                        case 3:
                    Console.WriteLine("Terça-Feira"); break;
                    case 4:
                    Console.WriteLine("Quarta-Feira"); break;
                    case 5:
                    Console.WriteLine("Quinta-Feira"); break;
                case 6:
                    Console.WriteLine("Sexta-Feira"); break;
                    case 7:
                    Console.WriteLine("Sábado"); break;
                default:
                    Console.WriteLine("Valor inválido"); break;
            }
        }
    }
}