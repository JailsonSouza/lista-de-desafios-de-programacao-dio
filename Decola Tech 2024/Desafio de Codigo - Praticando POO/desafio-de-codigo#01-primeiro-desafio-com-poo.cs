using System;

class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa(string n, int i)
    {
        nome = n;
        idade = i;
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
}

class Program
{
    static void Main()
    {
      string nomePessoa = Console.ReadLine();
      int idadePessoa = int.Parse(Console.ReadLine());
      
      Pessoa pessoa = new Pessoa(nomePessoa, idadePessoa);
      
      Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");
    }
}