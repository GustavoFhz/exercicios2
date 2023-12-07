namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma letra");
            char letra = char.Parse(Console.ReadLine());

            if (letra ==  'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' ) {

                Console.WriteLine("Essa letra é uma vogal");
            }
            else
            {
                Console.WriteLine("Essa letra é uma consoante");
            }
        }
    }
}