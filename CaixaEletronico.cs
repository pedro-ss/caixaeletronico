using System;

namespace caixaeletronico
{
    class CaixaEletronico
    {
        public void menu()
        {
            Console.WriteLine("Seja bem vindo ao caixa do seu banco.");
            Console.WriteLine("Favor selecionar uma das opções abaixo:");
            Console.WriteLine("1 - Criar conta");
            Console.WriteLine("2 - Fazer login em conta");
            Console.WriteLine("3 - Sair");
        }

        public Conta criarConta(Conta conta, Cliente cliente)
        {

            String numeroDaConta = "1234-5";
            String senha1, senha2;

            do
            {
                Console.WriteLine("Favor digite sua senha para posterior acesso:");
                senha1 = Console.ReadLine();
                Console.WriteLine("Favor digite novamente sua senha:");
                senha2 = Console.ReadLine();
                if (senha1.Equals(senha2))
                {
                    cliente.numeroConta = numeroDaConta;
                    cliente.senha = senha2;
                    conta.cliente = cliente;
                    conta.saldo = 0.0;
                    return conta;
                }
                else
                {
                    Console.WriteLine("Senhas diferentes");

                }
            } while (!senha1.Equals(senha2));

            return conta;
        }

        public Boolean login(Conta conta, Cliente cliente)
        {
            Boolean logged = false;

            if ((cliente.numeroConta).Equals(conta.cliente.numeroConta) && (cliente.senha).Equals(conta.cliente.senha))
            {
                Console.WriteLine("Cliente Logado");
                logged = true;
            }
            return logged;
        }
        static void Main(string[] args)
        {
            int option = -1;
            CaixaEletronico caixa = new CaixaEletronico();
            Cliente cliente = new Cliente();
            Conta conta = new Conta();

            while (option != 3)
            {
                caixa.menu();
                option = int.Parse(Console.ReadLine());
                if (option > 0 && option <= 3)
                {
                    if (option == 1)
                    {
                        conta = caixa.criarConta(conta, cliente);
                    }
                    else if (option == 2)
                    {
                        Cliente clienteAcess = new Cliente();
                        Console.WriteLine("Digite o numero da conta de acesso: ");
                        clienteAcess.numeroConta = Console.ReadLine();
                        Console.WriteLine("Digite a senha de sua conta: ");
                        clienteAcess.senha = Console.ReadLine();

                       if(caixa.login(conta, clienteAcess)){
                           Console.WriteLine("Seu saldo em conta é: ", conta.saldo);
                       }
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }

            }

        }
    }
}
