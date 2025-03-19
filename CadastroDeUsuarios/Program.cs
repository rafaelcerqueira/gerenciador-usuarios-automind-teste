using System;
using CadastroDeUsuarios.Services;

namespace CadastroDeUsuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Sistema de Cadastro de Usuário Automind!");
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            Console.WriteLine("\nEcolha uma opção:");
            Console.WriteLine("1 - Cadastrar Usuário");
            Console.WriteLine("2 - Listar Usuários");
            Console.WriteLine("0 - Sair");

            string opcao = Console.ReadLine() ?? string.Empty;

            switch (opcao)
            {
                case "1":
                    UsuarioService.CadastrarUsuario();
                    break;
                case "2":
                    UsuarioService.ListarUsuarios();
                    break;
                case "0":
                    Console.WriteLine("Encerrando...");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            MenuPrincipal();
        }
    }
}