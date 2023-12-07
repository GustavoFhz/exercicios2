namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o preço de 3 produtos:");
            double item1 = double.Parse(Console.ReadLine());
            double item2 = double.Parse(Console.ReadLine());
            double item3 = double.Parse(Console.ReadLine());

            if (item1 < item2 && item1 < item3) {
                Console.WriteLine("Você deve optar por comprar o item 1 por ser mais barato");
            }
            else if(item2 < item1 &&  item2 < item3)
            {
                Console.WriteLine("Você deve optar por comprar o item 2 por ser mais barato");
            }
            else if (item3 < item1 && item3 < item2)
            {
                Console.WriteLine("Você deve optar por comprar o item 3 por ser mais barato");
            }

            else { 
                Console.WriteLine("Os preços são igauis");
            }
        }
    }
}