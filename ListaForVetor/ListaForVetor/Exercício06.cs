using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaForVetor
{
    class Exercício06
    {
        public Exercício06()
        {
            //Crie um vetor que irá armazenar 10 números. Estes números deverão ser número
            //aleatórios.
            //Ao final apresente:
            //➔ Todos os números armazenados;
            //➔ A somatória final dos números;
            //➔ A média dos números;
            //➔ Quantidade de números pares;
            //➔ Quantidade de números positivos;
            //➔ Quantidade de números ímpares;
            //➔ Quantidade de números negativos;
            //➔ Quantidade de números neutros.
            //Observação: os números aleatórios devem ser gerados pelo C Sharp.

            Random randomNumber = new Random();

            int numeroAleatorio = 0;
            int quantidadeNumeros = 10;

            int soma = 0;
            int media = 0;

            int numerosPositivos = 0;
            int numerosNegativos = 0;
            int numerosNeutros = 0;
            int numerosPares = 0;
            int numerosImpares = 0;

            int[] numeros = new int [quantidadeNumeros];


            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = randomNumber.Next(-10, 10);

                if (numeros[i] > 0)
                {
                    numerosPositivos++;
                }
                else 
                {
                    numerosNegativos++;
                }
                if (numeros[i] %2 == 0)
                {
                    numerosPares++;
                }
                else
                {
                    numerosImpares++;
                }
                if (numeros[i] == 0)
                {
                    numerosNeutros++;
                }

                soma = soma + numeros[i];
                
            }
            media = soma / numeros.Length;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine(string.Format("\nQuantidade de números positivos: {0} " +
                                            "\nQuantidade de números negativos: {1}" +
                                            "\nQuantidade de números nêutros: {2}" +
                                            "\nQuantiadade de números ímpares: {3}" +
                                            "\nQuantidade de números pares {4}"+
                                            "\nSoma: {5}" +
                                            "\nMédia: {6}", numerosPositivos, numerosNegativos, numerosNeutros, numerosImpares,  numerosPares , soma, media));
                                           

            
        }
    }
}
