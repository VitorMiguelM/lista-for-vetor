using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForVetor
{
    class Exercício05
    {
        public Exercício05()
        {
            //A empresa GameVicio precisa armazenar os jogos que tem em estoque, para tal
            //deve-se armazenar o nome e a quantidade de jogos. Para tal utilize um vetor para o
            //nome dos jogos e outro vetor para a quantidade de jogos.
            //Ao final apresente o nome concatenado com a quantidade.
            //Exemplo:
            //Nome Unidades
            //God Of War 350
            //Spider-Man 59
            //Injustice 2 27
            //Crash Bandicoot 41
            //Grand Theft Auto V 12
            //Observação: A quantidade de jogos que serão cadastrados é o usuário que irá definir;

            int quantidadeJogosCadastrados = 0;

            bool validarQuantidade = true;

            while(validarQuantidade == true)
            {
                try
                {
                    Console.Write("Quantidade de jogos que deseja cadastrar: ");
                    quantidadeJogosCadastrados = Convert.ToInt32(Console.ReadLine());
                    validarQuantidade = false;

                    Console.Clear();
                }

                catch
                {
                    Console.WriteLine("Deveria Conter apenas números, tente novamente.");
                    Console.ReadKey();
                    Console.Clear();
                }

                string[] nomeJogos = new string[quantidadeJogosCadastrados];
                int[] quantidadeJogos = new int[quantidadeJogosCadastrados];

                for (int i = 0; i < quantidadeJogosCadastrados; i++)
                {
                    Console.Write("Jogo: ");
                    nomeJogos[i] = Console.ReadLine();
                    Console.Write("Quantidade: ");
                    quantidadeJogos[i] = Convert.ToInt32(Console.ReadLine());
                }





                    for (int i = 0; i < quantidadeJogosCadastrados; i++)
                    {
                        Console.WriteLine(string.Format("Jogo {0} - quantidade {1}", nomeJogos[i], quantidadeJogos[i]));
                    }

            }
        }
    }
}
