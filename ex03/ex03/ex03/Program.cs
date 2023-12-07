namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 'F' para Feminino e 'M' para Masculino");
            char genero = char.Parse(Console.ReadLine());

            switch (genero)
            { case 'F': Console.WriteLine("Feminino"); break;

              case 'M': Console.WriteLine("Masculino"); break;

              default: Console.WriteLine("Sexo Inválido"); break;
            }
            
            
        }
    }
}