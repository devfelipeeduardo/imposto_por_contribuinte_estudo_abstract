using System.Diagnostics;
using System.Globalization;
using Course.Entities;

namespace Course {

    class Program {

        static void Main(string[]args ){

            List<Contribuinte> lista = new List<Contribuinte>();

            Console.Write("Quantidade de Contribuintes: ");
            int qtd_contribuintes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd_contribuintes; i++){

                Console.WriteLine($"Contribuinte {i}");
                Console.Write("Pessoa Fisica ou Juridica? [F/J]: ");
                string contribuinte = Console.ReadLine().ToLower();

                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double RendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (contribuinte == "f") {
                    
                    Console.Write("Valor Total dos Gastos com Sáude: ");
                    double GastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new PessoaFisica (Nome, RendaAnual, GastosComSaude));

                } else{

                    Console.Write("Quantidade de funcionários: ");
                    int QuantidadeFuncionarios = int.Parse(Console.ReadLine());

                    lista.Add(new PessoaJuridica (Nome, RendaAnual, QuantidadeFuncionarios));

                }
            }

            Console.WriteLine("Contribuintes: ");

            foreach (Contribuinte contribuinte in lista){

                Console.WriteLine(contribuinte);

            }


        }
    }
}