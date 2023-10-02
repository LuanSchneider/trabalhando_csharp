
/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Net; 

namespace consoleApp
{
    class program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            int numero_2 = 5;
            Console.WriteLine("quem é "+numero+"+"+numero_2+ "?");
            int resposta=Convert.ToInt32(Console.ReadLine());
            if (resposta == 15)
            {
                Console.WriteLine("parabens!! ");
            }
            else
                Console.WriteLine("tente de novo");

        }
    }
}
*/

/*namespace helloword
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello word");
            Console.WriteLine("meu nome é Luan Schneider");
            int idade = 20;
            Console.WriteLine("minha idade é"+idade); 
            Console.ReadLine();

        }
    }
}*/

using System;

namespace ConversorMoedas
{
    abstract class Conversor
    {
       public abstract decimal Converter(decimal valor);
    
        public void Imprimir(decimal valor)
        {
            Console.WriteLine("Valor convertido: " + Converter(valor));
        }
    }

    class RealParaDolar : Conversor
    {
        private decimal taxaCambio = 5.23m;

        public override decimal Converter(decimal valor)
        {
            return valor / taxaCambio;
        }
    }

    class RealParaEuro : Conversor
    {
6        private decimal taxaCambio = 6.19m;

        public override decimal Converter(decimal valor)
        {
            return valor / taxaCambio;
        }
    }

  
    class DolarParaReal : Conversor
    {
       
        private decimal taxaCambio = 5.23m;

       
        public override decimal Converter(decimal valor)
        {
            return valor * taxaCambio;
        }
    }

   
    class EuroParaReal : Conversor
    {
      
        private decimal taxaCambio = 6.19m;

        /
        public override decimal Converter(decimal valor)
        {
            return valor * taxaCambio;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Conversor de Moedas!");

            bool executando = true;

            while (executando)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Real para Dólar");
                Console.WriteLine("2 - Real para Euro");
                Console.WriteLine("3 - Dólar para Real");
                Console.WriteLine("4 - Euro para Real");
                Console.WriteLine("5 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ExecutarConversao(new RealParaDolar());
                        break;
                    case 2:
                        ExecutarConversao(new RealParaEuro());
                        break;
                    case 3:
                        ExecutarConversao(new DolarParaReal());
                        break;
                    case 4:
                        ExecutarConversao(new EuroParaReal());
                        break;
                    case 5:
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void ExecutarConversao(Conversor conversor)
        {
            Console.WriteLine("Digite o valor a ser convertido: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            conversor.Imprimir(valor);
        }
    }
}
