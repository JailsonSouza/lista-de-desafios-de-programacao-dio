using System;

class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}

class Program
{
    static void Main()
    {
        string[] valoresDeEntradaVelocidade = Console.ReadLine().Split(' ');
        int velocidadeMin = Convert.ToInt32(valoresDeEntradaVelocidade[0]);
        int velocidadeMax = Convert.ToInt32(valoresDeEntradaVelocidade[1]);
        int limiteCaractere = 100;

        Robo robo = new Robo(velocidadeMin, velocidadeMax);

        string valoresDeEntradaComandos = Console.ReadLine().ToUpper();
        
        if (valoresDeEntradaComandos.Length <= limiteCaractere)
        {
            foreach (var comando in valoresDeEntradaComandos)
                {
                    if (comando.Equals('A'))
                    {
                        robo.Acelerar();
                    } else if (comando.Equals('D'))
                    {
                        robo.Desacelerar();
                    }
                }
                
                Console.WriteLine(robo.VelocidadeAtual);
        }
        else {
            Console.WriteLine("Excedeu a quantidade máxima de caracteres!");
        }
    }
}