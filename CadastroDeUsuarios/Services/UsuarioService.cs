using System;
using System.Collections.Generic;
using CadastroDeUsuarios.Models;

namespace CadastroDeUsuarios.Services
{
    public static class UsuarioService
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        public static void CadastrarUsuario()
        {
            Console.WriteLine("\nDigite o nome do usuário:");
            string nome = Console.ReadLine();

            Console.WriteLine("\nDigite o e-mail do usuário:");
            string email = Console.ReadLine();

            Console.WriteLine("\nDigite a idade do usuário:");
            int idade;
            while(!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.WriteLine("Por favor, insira uma idade válida:");
            }

            usuarios.Add(new Usuario { Nome = nome, Email = email, Idade = idade});
            Console.WriteLine("Usuário cadastrado com sucesso!");

        }
    }
}