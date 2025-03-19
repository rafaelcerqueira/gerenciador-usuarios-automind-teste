# Cadastro de Usuários
Este é um projeto simples de console desenvolvido em C# com o framework .NET. A aplicação permite gerenciar usuários com as funcionalidades de cadastro, listagem e busca. Este projeto foi estruturado para ser organizado e fácil de usar.

## Funcionalidades
- **Cadastro de Usuários**: Permite registrar usuários informando nome, e-mail e idade.
- **Listagem de Usuários**: Exibição de todos os usuários cadastrados.
- **Busca de Usuário**: Pesquisa por nome para exibir detalhes do usuário.

## Tecnologias Utilizadas
- Linguagem: C#
- Framework: .NET 9.0
- Projeto desenvolvido com IDE Visual Studio Code (optei por essa IDE porque utilizei o SO Linux)
- CLI do .NET: Utilizado para criar e executar o projeto.

## Como Executar o Projeto

Antes de executar o programa, certifique-se de que possui os seguintes itens instalados no seu ambiente:

1. Certifique-se de que o .NET SDK 9.0 ou superior está instalado no seu ambiente.
   - Para instalar, siga as instruções oficiais para Linux, Windows ou MacOS.

2. Git (para clonar o repositório)
   - Clone o repositório:
      ```bash
      git clone <https://github.com/rafaelcerqueira/gerenciador-usuarios-automind-teste>
      cd CadastroDeUsuarios
3. Visual Studio Code (Opcional)

## Passos para Configurar o Ambiente
1. Clone o repositório:
   ```bash
   git clone <https://github.com/rafaelcerqueira/gerenciador-usuarios-automind-teste>
   cd CadastroDeUsuarios

2. Execute o programa:
   - No terminal, utilize os comandos abaixo:
   ```bash
   dotnet run

3. Interaja com o menu:
   - Escolha as opções do menu para cadastrar, listar ou buscar usuários:
      - 1: Cadastrar Usuário
      - 2: Listar Usuários
      - 3: Buscar Usuário
      - 0: Sair

## Como Usar o Programa
1. Execute o programa com `dotnet run`
2. Escolha uma das opções do menu exibido:
   - Cadastro de Usuários: Digite o nome, e-mail e idade. Você receberá uma confirmação ao final.
   - Listagem de Usuários: Todos os usuários cadastrados serão exibidos.
   - Busca de Usuários: Digite o nome para buscar. Se encontrado, os detalhes do usuário serão exibidos.
3. Caso queira finalizar, ecolha a opção 0 - Sair.

## Próximos Passos (Expansão do projeto)
Esse é um projeto simples de gerenciamento de usuários. Podemos melhorar a aplicação e adicionar algumas funcionalidades:
- Persistência de dados: Podemos armazenar os usuários em um banco de dados ou arquivo local para que as informações sejam salvas mesmo após fechar o programa.
- Validações avançadas: Verificar e-mails válidos e evitar duplicidade de usuários.
- Interface Gráfica: Evoluir de um programa de console para uma aplicação com interface gráfica utilizando WinForms ou WPF.
- Teste Unitário: Implementar testes com ferramentas como xUnit para validar as funcionalidades

## Autor
Essa aplicação foi desenvolvida por Rafael Freitas.