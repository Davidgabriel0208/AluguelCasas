using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCasas
{
    class Menu
    {

        public string menu()
        {
            Console.Clear();
            Console.WriteLine("1 -Cadastrar Cliente");
            Console.WriteLine("Q -Sair");
            Console.WriteLine("Escolha uma opcao:");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();

        }

    }
}
