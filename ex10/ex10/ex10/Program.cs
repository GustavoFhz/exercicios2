namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que turno vc estuda? M-matutino ou V-Vespertino ou N- Noturno.");
            char turno = char.Parse(Console.ReadLine());

            switch (turno) {
            case 'm': Console.WriteLine("Bom dia"); break;
                case 'v':
                    Console.WriteLine("Boa tarde"); break;
                case 'n':
                    Console.WriteLine("Boa noite"); break;
                default: Console.WriteLine("Valor Inválido"); break;


            }

        }
    }
}