namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a nota 1");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a  nota 2");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2 ;

            if(media == 10)
            {
                Console.WriteLine("Aprovado com Distinção");
            }

            else if (media < 7)
            {
                Console.WriteLine("Reprovado");
            }
            else if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
        }
    }
}