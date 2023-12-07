using System.Runtime.Intrinsics.X86;

namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 3 números");

            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            if(n1 < n2 && n1 < n3 && n2 < n3 )
            {
                // n1 é menor 
                // n3 é o maior
                // n1 < n2 < n3
                Console.WriteLine(n3 + " " + n2 + " " + n1);
            } 
            else if (n1 < n2 && n1 < n3 && n3 < n2)
            {
                // n1 é menor 
                // n2 é o maior
                // n1 < n3 < n2

                Console.WriteLine(n2 + " " + n3 + " " + n1);
            }
            else if(n2 < n1 && n2 < n3 && n1 < n3)
            {
                // n2 é menor 
                // n3 é o maior
                // n2 < n1 < n3
                Console.WriteLine(n3 + " " + n1 + " " + n2);
            }

            else if (n2 < n1 && n2 < n3 && n3 < n1)
            {
                //num2 é menor
                //num1 é maior
                // num2 < num3 < num1
                Console.WriteLine(n1 + " " + n3 + " " + n3);
            }
            else if (n3 < n1 && n3 < n2 && n1 < n2)
            {
                //num3 é menor
                //num2 é maior
                // num3 < num1 < num2
                Console.WriteLine(n2 + " " + 1 + "" + n3);

            }
            else if (n3 < n1 && n3 <= n2 && n2 <= n1)
            {
                //num3 é menor
                //num1 é maior
                // num3 < num2 < num1
                Console.WriteLine(n1 + " " + n2 + " " + n3);


            }
        }
}