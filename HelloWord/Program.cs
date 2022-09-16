using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // --- Var --- //
            // Int - Armazenar dados como numeros inteiros -156 como 32334
            // Float - Flutuante é um numero como se fosse inteiro pode ser negativo ou positivo mais usa ponto ex: -15.6 como 232.78
            // Bool - Pode ter dois valores true ou false
            // String - Identificado por ""
            // Char - 'a' caracter

            // A - Z
            //0 - 9
            // NÃO PODE USAR PALAVRAS RESERVADAS
            // _
            // @ $ . 

            /*
            int segundaGuerraMundial = 1939;
            string corFavorita = "Azul Claro";
            float velocidadeF1 = 360.5f;  // Trabalhar com float tem que colocar o f no final do numero exemplo: 158.99f
            bool segundaGuerraMundialAconteceu = true;


            Console.WriteLine("A data da segunda Guerra Mundial foi em 1 de setembro de " + segundaGuerraMundial);
            Console.WriteLine(segundaGuerraMundialAconteceu);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(corFavorita);

            velocidadeF1 = 349.90f; //Alteração de variavel
            corFavorita = "Roxo";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(corFavorita);


            Console.WriteLine("Hello World");     // (N) QUEBRA A LINHA !

            Console.WriteLine("Meu nome e JKS!");  // (N) QUEBRA A LINHA !  WriteLine QUEBRA A LINHA TBM!
            */


            // --- Variavel dinamica --- // 

            /*
            dynamic corFavorita = "Vermelho";

            Console.WriteLine(corFavorita);

            corFavorita = 12321313;

            Console.WriteLine(corFavorita);
            */

            // --- Const pode definir uma vez só, n tem como alterar --- // 

            // const float PI = 3.231231321f;


            string nome = "";
            Console.WriteLine("Escreve seu Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);


            Console.ReadLine();



        }
    }
}
