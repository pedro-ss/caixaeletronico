using System;

namespace caixaeletronico
{
    class CaixaEletronico
    {
        public void menu(){
            Console.WriteLine("Seja bem vindo ao caixa do seu banco.");
            Console.WriteLine("Favor selecionar uma das opções abaixo:");
            Console.WriteLine("1 - Criar conta");
            Console.WriteLine("2 - Fazer login em conta");
            Console.WriteLine("3 - Sair");
        }

        public void criarConta(){

        }

        public Boolean login(){
            Boolean logged = false;
            
            return logged;
        }
        static void Main(string[] args)
        {
            int option;
            CaixaEletronico caixa = new CaixaEletronico();
            caixa.menu();
            option = int.Parse(Console.ReadLine());

            if(option > 0){
                Console.WriteLine("Opção válida!");
            }
        }
    }
}
