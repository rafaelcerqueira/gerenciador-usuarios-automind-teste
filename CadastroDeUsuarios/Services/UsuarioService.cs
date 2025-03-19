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
            string nome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("\nDigite o e-mail do usuário:");
            string email = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("\nDigite a idade do usuário:");
            int idade;
            while(!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.WriteLine("Por favor, insira uma idade válida:");
            }

            usuarios.Add(new Usuario
            {
                Nome = nome,
                Email = email,
                Idade = idade
            });
            Console.WriteLine("Usuário cadastrado com sucesso!");

        }

        public static void ListarUsuarios()
        {
            Console.WriteLine("\nUsuários cadastrados:");
            if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado no momento.");
                return;
            }

            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"Nome: {usuario.Nome}, E-mail: {usuario.Email}, Idade: {usuario.Idade}");
            }
        }

        public static void BuscarUsuario()
        {
            Console.WriteLine("\nDigite o nome do usuário que deseja buscar:");
            string nome = Console.ReadLine() ?? string.Empty;

            var usuarioEncontrado = usuarios.Find(u => u.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (usuarioEncontrado != null)
            {
                Console.WriteLine($"Usuário encontrado:\nNome: {usuarioEncontrado.Nome}, \nE-mail: {usuarioEncontrado.Email}, \nIdade: {usuarioEncontrado.Idade}");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }

        }
    }
}