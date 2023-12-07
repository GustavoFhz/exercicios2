namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salário para ser calculado o reajuste");
            double salario = double.Parse(Console.ReadLine());

            double salarioInformado = salario;
           

            if(salario == 280)
            {
                double percentual = 0.20;
                salario += salario * percentual;
        
                Console.WriteLine($"O percentual de aumento aplicado foi de 20 %");            

            } 
            else if(salario >= 280 && salario <= 700)
            {
                double percentual = salario * 0.15;
                salario += percentual;

                Console.WriteLine($"O percentual de aumento aplicado foi de: 15%");               
            }
            else if(salario >= 700 && salario <= 1500)
            {
                double percentual = salario * 0.10;
                salario += percentual;

                Console.WriteLine($"O percentual de aumento aplicado foi de: 10%");

            }
            else if(salario >= 1500)
            {
                double percentual = salario * 0.05;
                salario += percentual;
            
                Console.WriteLine($"O percentual de aumento aplicado foi de: 5%");
               
            }

            Console.WriteLine($"O salário antes do reajuste é de {salarioInformado}");
            Console.WriteLine($"O valor do aumento foi de {salario - salarioInformado}");
            Console.WriteLine($"O novo salário é de {salario}");

        }
    }
}