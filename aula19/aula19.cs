//Loop For / Estruturas de iteração
//usando Biblioteca do Sistema
using System;
//criando classe
class Aula19{
    //criando me metodo Principal
    static void Main(){
        //criando um vetor
        int[] n = new int[10];
        //Criando loop for , ele repete ate o numero num inicial for igual ao segundo e terceiro de quanto em quanto
        for(int i=0;i<n.Length;i++){
            n[i]=0;
            
        }
        for(int i=0;i<10;i++){
            Console.WriteLine("Valor de num na pos{0}:{1}",i,n[i]);
        }
    }
}