// Matrizes / Vetores - Bdimensonais
// usando Biblioteca do Sistema
using System;
//criando classe
class Aula18{
    //criando meu metodo principal
    static void Main(){
        //criando meu array
        int[,] n = new int[3,5];
        int[,] num = new int[2,2]{{10,20},{30,40}};
        /*  irei montar vetores assim
        10 20 30 40 50 
        11 21 31 41 51
        15 25 35 45 55
        */
        //adicionando conteudo 
        n[0,0]=10; n[0,1]=20; n[0,2]=30; n[0,3]=40; n[0,4]=50;
        n[1,0]=11; n[1,1]=21; n[1,2]=31; n[1,3]=41; n[1,4]=51;
        n[2,0]=15; n[2,1]=25; n[2,2]=35; n[2,3]=45; n[2,4]=55;

        //exibindo um dos resultados
        Console.WriteLine(n[2,3]);
        Console.WriteLine(n[0,0]);
        
    }
}