using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForVetor
{
    class Exercício01
    {
        public Exercício01()
        {
            //Desenvolver um programa que armazene 25 nomes, para tal utilize um vetor com 25
            //posições e o comando for​ para armazenar os valores.
            //Observação: para armazenar os valores deve-se solicitar os nomes ao usuário.

            
            for (int i = 0; i < 25; i++)
            {
                string[] nomes = new string[25];
                Console.Write("Digite um nome: ");
                nomes[i] = Console.ReadLine();
            }
        }
    }
}
