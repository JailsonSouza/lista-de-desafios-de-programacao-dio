using System;

class Program
{
    static void Main(string[] args)
    {

// TODO: Declare as variáveis para guardar as informações de nome, email e senha:
// Obtém o email e nome do usuário a partir da entrada do console
    string registroEmail = Console.ReadLine();
    string registroNome = Console.ReadLine();
    string registroSenha = Console.ReadLine();

// TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
    Console.WriteLine(registroNome + ", verifique o email: " + registroEmail + " para ativar.");

    }
}