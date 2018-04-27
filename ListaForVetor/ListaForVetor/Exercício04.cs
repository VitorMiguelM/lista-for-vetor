using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForVetor
{
    class Exercício04
    {
        public Exercício04()
        {
            //Desenvolver um programa que armazene o tamanho de 40 camisas, após isto
        //apresentar:
        //➔ Tamanho de todas as camisas armazenadas
        //➔ Quantidade de camisas PP
        //➔ Quantidade de camisas P
        //➔ Quantidade de camisas M
        //➔ Quantidade de camisas G
        //➔ Quantidade de camisas GG
        //➔ Quantidade de camisas XG
        //➔ Quantidade de camisas XGG
        
        //Lembrando que os tamanhos possíveis para camisas são:
        //➔ PP
        //➔ P
        //➔ M
        //➔ G
        //➔ GG
        //➔ XG
        //➔ XGG



            string[] tamanhoCamisas = new string[40];
            
            int quantidadePP = 0;
            int quantidadeP = 0;
            int quantidadeM = 0;
            int quantidadeG = 0;
            int quantidadeGG = 0;
            int quantidadeXG = 0;
            int quantidadeXGG = 0;

            for(int i = 0; i < tamanhoCamisas.Length; i++)
            {
                Console.Write("Tamanho da camisa: ");
                tamanhoCamisas[i] = Console.ReadLine().ToLower();

                if (tamanhoCamisas[i] == "pp")
                {
                    quantidadePP++;
                }
                else if (tamanhoCamisas[i] == "p")
                {
                    quantidadeP++;
                }
                else if (tamanhoCamisas[i] == "m")
                {
                    quantidadeM++;
                }
                else if (tamanhoCamisas[i] == "g")
                {
                    quantidadeG++;
                }
                else if (tamanhoCamisas[i] == "gg")
                {
                    quantidadeGG++;
                }
                else if (tamanhoCamisas[i] == "xg")
                {
                    quantidadeXG++;
                }
                else if (tamanhoCamisas[i] == "xgg")
                {
                    quantidadeXGG++;
                }

            }
            Console.WriteLine("Quantidade de camisas PP: " + quantidadePP);
            Console.WriteLine("Quantidade de camisas P: " + quantidadeP);
            Console.WriteLine("Quantidade de camisas M: " + quantidadeM);
            Console.WriteLine("Quantidade de camisas G: " + quantidadeG);
            Console.WriteLine("Quantidade de camisas GG: " + quantidadeGG);
            Console.WriteLine("Quantidade de camisas XG: " + quantidadeXG);
            Console.WriteLine("Quantidade de camisas XGG: " + quantidadeXGG);
        }
    }
}
