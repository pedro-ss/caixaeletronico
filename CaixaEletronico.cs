using System;

namespace caixaeletronico
{
    class CaixaEletronico
    {
        public void menu()
        {
            Console.WriteLine("#######################################");
            Console.WriteLine("Seja bem vindo ao caixa do seu banco.");
            Console.WriteLine("Favor selecionar uma das opções abaixo:");
            Console.WriteLine("1 - Criar conta");
            Console.WriteLine("2 - Fazer login em conta");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("######################################");
        }
        public void criarConta(Conta account, Cliente user)
        {
            Console.WriteLine("Conta criada");
        }
        public void login(Conta account, Cliente user)
        {
            Console.WriteLine("Conta acessada");
        }
        public void limparLinha()
        {
            for (int cont = 0; cont < 10; cont++)
            {
                Console.WriteLine("");
            }
        }

        public void escolhaMenu(int escolhaUser)
        {
            if (escolhaUser == 1)
            {
                criarConta(null, null);
            }
            else if (escolhaUser == 2)
            {
                login(null, null);
            }
            else
            {
                Console.WriteLine("#######################################");
                Console.WriteLine(" Obrigado e volte sempre!");
                Console.WriteLine("#######################################");
            }
        }
        static void Main(string[] args)
        {
            CaixaEletronico caixa = new CaixaEletronico();
            Cliente marta = new Cliente();
            Conta contaMarta = new Conta();

            caixa.menu();
            int escolhaUser = int.Parse(Console.ReadLine());
            caixa.escolhaMenu(escolhaUser);
            
        }
    }
}
