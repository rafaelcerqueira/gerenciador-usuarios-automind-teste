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
            //Opções de escolha das funcionalidades. Selecione uma das opções ao rodar o projeto no terminal
            Console.WriteLine("\nEcolha uma opção:");
            Console.WriteLine("1 - Cadastrar Usuário");
            Console.WriteLine("2 - Listar Usuários");
            Console.WriteLine("3 - Buscar Usuários");
            Console.WriteLine("0 - Sair");

            string opcao = Console.ReadLine() ?? string.Empty;

            //De acordo com a opção selecionada, o programa irá rodar um dos métodos. 
            switch (opcao)
            {
                case "1":
                    UsuarioService.CadastrarUsuario();
                    break;
                case "2":
                    UsuarioService.ListarUsuarios();
                    break;
                case "3":
                    UsuarioService.BuscarUsuario();
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