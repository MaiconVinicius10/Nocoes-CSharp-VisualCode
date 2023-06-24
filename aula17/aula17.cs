//Array e Vetor
//usando a biblioteca do sistema
using System;
//Criando classe
class Aula17{
    //criando metodo principal
    static void Main(){
        // int n1,n2,n3,n4,n5;
        //criando array do tipo inteiro
        //exemplo1
        int[] n= new int[5]; //0-4

        n[0]=11;
        n[1]=22;
        n[2]=33;
        n[3]=44;
        n[4]=55;

        Console.WriteLine(n);

        //exemplo2
        //criando array do tipo inteiro
        int[] n2= new int[3]{55,77,99};

        Console.WriteLine(n2);


    }
}