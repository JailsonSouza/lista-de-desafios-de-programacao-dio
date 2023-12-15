using System;

class Program
{
    static void Main()
    {

// TODO: Crie as variáveis titulo, descricao e dataVencimento para guardar as informações das tarefas:
      string titulo;
      string descricao;
      string dataVencimento;
          
   // Obtém o titulo e a descricao a partir da entrada do console  
      titulo = Console.ReadLine();
      descricao = Console.ReadLine();
  
  // TODO: Crie uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres.
      if (descricao.Length > 50)
      {
        Console.WriteLine("Descricao ultrapassa limite de caracteres.");
      }
      else
      {
        
   // Caso a descricao esteja dentro do limite é solicitado a entrada pelo console:
        dataVencimento = Console.ReadLine();
  
  
   // TODO: Imprima a descricao e a data de vencimento como nos exemplos da tabela:            
        Console.WriteLine(descricao + " ate " + dataVencimento);
            
      }
    }
}