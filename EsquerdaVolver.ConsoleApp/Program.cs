using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Informe o limite de comandos: Ex(3,7 e 0 para sair)");
                int numComandos = Convert.ToInt32(Console.ReadLine());
                if (numComandos == 0) break;
                Console.WriteLine("Informe o Comando: Ex(DDED)");
                string comandos = Console.ReadLine().ToLower();; 
                string direcao = "n";

                for (int i = 0; i < numComandos; i++)   // numComandos executa apenas a quantidade especificade de X as direções
                {
                    if (comandos.Length < numComandos)  // caso informe 3 e apenas DD ele executa apenas o DD e para a execução
                    {
                        if (i == comandos.Length) break;
                    }   
                    

                    if (comandos[i] == 'd')
                    {
                        if (direcao == "s") direcao = "o";
                        else if (direcao == "n") direcao = "l";
                        else if (direcao == "l") direcao = "s";
                        else if (direcao == "o") direcao = "n";
                    }
                    else if (comandos[i] == 'e')
                    {
                        if (direcao == "s") direcao = "l";
                        else if (direcao == "n") direcao = "o";
                        else if (direcao == "l") direcao = "n";
                        else if (direcao == "o") direcao = "s";
                    }

                }
                Console.WriteLine(direcao);
                Console.ReadKey();
                Console.Clear();
            }


        }
    }
}
