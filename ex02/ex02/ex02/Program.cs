namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor na tela");
            double valor = double.Parse(Console.ReadLine());

            if(valor < 0)
            {
                Console.WriteLine("O valor é negativo");
            }
            else
            {
                Console.WriteLine("O valor é positivo");
            }
           
        }
    }
}