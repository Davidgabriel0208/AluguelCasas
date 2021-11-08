using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCasas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Menu menu = new Menu();
            Cliente cliente = new Cliente();
            do
            {
                opcao = menu.menu();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastrar Cliente");
                        cliente.cadastrarCliente();
                        Console.ReadKey();
                        break;
                    case "Q":
                        Console.WriteLine("Encerrando o programa");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            } while (opcao != "Q");
            //Environment.Exit(0);
        }
    }
}
