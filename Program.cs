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
                        break;
                        case "2":
                        break;
                        case "3":
                        break;
                        case "4":
                        break;
                        case "5":
                        break;
                        case "C":
                        break;
                        case "":
                        break;

                        default:
                            Console.WriteLine("Valor digitado invalido");
                    }
                }
            
        }
        private static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("DIO Bank a eu dispor!!!");
                Console.WriteLine("Informe a opção desejada");
                
                Console.WriteLine("1- Listar conta");
                Console.WriteLine("2- Inerir nova conta");
                Console.WriteLine("3- Transsferir");
                Console.WriteLine("4- sacar");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                return "x";
            }
    }
}
