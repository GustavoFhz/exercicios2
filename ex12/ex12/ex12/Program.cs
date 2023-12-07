namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da sua hora de trabalho");
            double hora = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas trabalhada no mês");
            double qtdHora = double.Parse(Console.ReadLine());

            double salarioBruto = hora * qtdHora;

            double ir = 0;

            if(salarioBruto <= 900)
            {
                ir = 0;
            }
            else if (salarioBruto > 900 && salarioBruto <= 1500)
            {
                ir = salarioBruto * 0.05;
            }
            else if(salarioBruto > 1500 && salarioBruto <= 2500)
            {
                ir = salarioBruto * 0.10;
            }
            else if(salarioBruto > 2500)
            {
                ir = salarioBruto * 0.20;
            }
            

            double sindicato = salarioBruto * 0.03;
            double fgts = salarioBruto * 0.11;
            double inss = salarioBruto * 0.10;

            double descontos = ir + sindicato + inss;
            double salarioLiquido = salarioBruto - descontos;

            Console.WriteLine($"Salário Bruto {hora} * {qtdHora} : R$ {salarioBruto}");
            Console.WriteLine($"IR ({ir}): R$ {ir}");
            Console.WriteLine($"Sindicato R$ {sindicato}");
            Console.WriteLine($"FGTS (11%): R$ {fgts}");
            Console.WriteLine($"INSS (10%): R$ {inss}");
            Console.WriteLine($"Total de descontos R$ {descontos}");
            Console.WriteLine($"Salário Liquido R$ {salarioLiquido}");


        }
    }
}