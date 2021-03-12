using System;

namespace DIO.Bank
{
    class Program
    {
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
                          // InserirConta();
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
