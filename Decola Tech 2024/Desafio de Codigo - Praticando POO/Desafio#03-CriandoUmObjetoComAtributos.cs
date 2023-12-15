using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador(string nome, string nacionalidade, int idade, string posicao)
    {
      Nome = nome;
      Nacionalidade = nacionalidade;
      Idade = idade;
      Posicao = posicao;
    }
}

class Program
{
    static void Main()
    {
      string nomeJogador = Console.ReadLine();
      string nacionalidadeJogador = Console.ReadLine();
      int idadeJogador = int.Parse(Console.ReadLine());
      string posicaoJogador = Console.ReadLine();
      
      Jogador jogador = new Jogador(nomeJogador, nacionalidadeJogador, idadeJogador, posicaoJogador);
      
      Console.WriteLine("Jogador criado!");
      Console.WriteLine($"{jogador.Nome}");
      Console.WriteLine($"{jogador.Nacionalidade}");
      Console.WriteLine($"{jogador.Idade}");
      Console.WriteLine($"Posição: {jogador.Posicao}");
    }
}