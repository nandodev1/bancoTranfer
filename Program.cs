using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();

        static void Main(string[] args)
        {
                string opcaoUsuario = ObterOpcaoUsuario();
                while(opcaoUsuario.ToUpper() != "X")
                {
                    switch(opcaoUsuario)
                    {
                        case "1":
                          // ListarConta();
                        break;
                        case "2":
                          InserirConta();
                        break;
                        case "3":
                          // Transferir();
                        break;
                        case "4":
                          // Sacar(); 
                        break;
                        case "5":
                          // Depositar(); 
                        break;
                        case "C":
                          // Console.clear();
                        break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    opcaoUsuario = ObterOpcaoUsuario();
                }
                Console.WriteLine("Obrigado por ultilizar nossos serviços.");
                Console.ReadLine();
            
        }

        private static void InserirConta()
        {
          Console.WriteLine("Inserir Nova Cela");
          Console.Write("Digite 1 para conta fisica e 2 para conta juridica: ");
          int entradaTipoConta = int.Parse(Console.ReadLine());


          Console.Write("Digite o Nome do Cliente: ");
          string entradaNome = Console.ReadLine();

          Console.Write("Digite saldo inicial: ");
          double entradasaldo = double.Parse(Console.ReadLine());

          Console.Write("Digite Créédito: ");
          double entradaCredito = double.Parse(Console.ReadLine());

          Conta conta = new Conta(tipoConta: entradaTipoConta,
                                  saldo: entradasaldo,
                                  credito:entradaCredito,
                                  nome: entradaNome);

        }

        private static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("DIO Bank a eu dispor!!!\n");
                Console.WriteLine("Informe a opção desejada");
                
                Console.WriteLine("1- Listar conta");
                Console.WriteLine("2- Inerir nova conta");
                Console.WriteLine("3- Transferir");
                Console.WriteLine("4- sacar");
                Console.WriteLine("5- Depositar");
                Console.WriteLine("c- Linpar tela");
                Console.WriteLine("x- Sair");

                string opcaoUsuario = Console.ReadLine().ToUpper();
                return opcaoUsuario;
            }
    }
}
