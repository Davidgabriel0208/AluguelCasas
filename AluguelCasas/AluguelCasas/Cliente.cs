using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCasas
{
    class Cliente
    {
        private string nome;
        private double cpf;
        private double rg;
        private double valormax;
        private double telefone;
        private string email;
        private string municipio;
        private string bairro;

        public void cadastrarCliente()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o RG");
            rg = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Telefone");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o email");
            email = Console.ReadLine();
            Console.WriteLine("Digite o municipio de preferência em São Paulo(caso não tenha, digite 0)");
            municipio = Console.ReadLine();
            Console.WriteLine("Digite o bairro de sua preferência em São Paulo(caso não tenha, digite 0)");
            bairro = Console.ReadLine();
            Console.WriteLine("DIgite o valor máximo do aluguel");
            valormax = double.Parse(Console.ReadLine());
            Console.WriteLine("Seu cadastro foi realizado, entraremos em contato via telefone informado, caso tenha algum imóvel nas suas preferências." +
                "Obrigado pela preferência!");




        }

        public void mostrarCadastro()
        {
            Console.WriteLine("--- Cadastro ---");
            Console.WriteLine("Nome:{0}", nome);
            Console.WriteLine("CPF:{0}", cpf);
            Console.WriteLine("RG:{0}", rg);
            Console.WriteLine("telefone:{0}", telefone);
            Console.WriteLine("email:{0}", email);
            Console.WriteLine("municipio:{0}", municipio);
            Console.WriteLine("bairro:{0}", bairro);
            Console.WriteLine("valor máximo:{0}", valormax);
        }

        public string nomeCliente()
        {
            return nome;
        }


    }
}