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

            Console.Write("Quantos jogos deseja armazenar? ");
            int quantidadeJogosArmazenar = Convert.ToInt32(Console.ReadLine());

            int[] quantidadeJogos = new int[quantidadeJogosArmazenar];

            string[] nomesJogos = new string[quantidadeJogosArmazenar];
            
    

        }
    }
}
