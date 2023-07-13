// Métodos para Arrays
using System;
//criando classe 
class Aula23{
    //criando metodo principal
    static void Main(){
        //criando 3 vetores 
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        //criando uma matriz;
        int[,] matriz = new int[2,5]{{11,22,33,44,55},{66,77,88,99,100}};
        //Criando meu Random para valores aleatórios
        Random random = new Random();
        for(int i=0; i<vetor1.Length; i++){
            vetor1[i]= random.Next(50);
        }
        //colocando nome antes de exibir
        Console.WriteLine("Elementos de vetor1 , Criando valores aleatorios");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }


    }
}