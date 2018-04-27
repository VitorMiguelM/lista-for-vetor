using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForVetor
{
    class Exercício03
    {
        public Exercício03()
        {
            //Desenvolver um programa que armazene preços, deve-se solicitar ao usuário a
            //quantidade de registros que o mesmo deseja armazenar. Após isto, solicitar os
            //preços de acordo com a quantidade de registros.
            //Ao final apresentar todos os preços e o total dos preços.
            //Observação: não deve ser solicitado o preço total e sim utilizar o vetor.

            Console.Write("Quantidade de registros que deseja armazenar: ");
            int quantidadeRegistros = Convert.ToInt32(Console.ReadLine());

            int[] registros = new int[quantidadeRegistros];
            double[] precos = new double[quantidadeRegistros];
            
            for(int i = 0; i < quantidadeRegistros; i++)
            {
                Console.Write("Informe os preços: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());

            }



            double total = 0;
            for (int i = 0; i < quantidadeRegistros; i++) 
            {
                total = precos[i] + total;
                
            }
          
            Console.WriteLine("O total dos preços é de: " + total);

            

        }
    }
}
