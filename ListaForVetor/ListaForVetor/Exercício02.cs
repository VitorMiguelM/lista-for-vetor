using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForVetor
{
    class Exercício02
    {
        public Exercício02()
        {
            //Desenvolver um programa que armazene 7 idades, armazenar em um vetor,
            //solicitando ao usuário e ao final apresentar as idades ao usuário.

            int[] idades = new int[7];
            for(int i = 0; i < 7; i++)
            {
                Console.Write("Digite a idade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("As idades cadastradas são: " + idades[i]);

            }
        }
    }
}
