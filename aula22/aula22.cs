//Loop foreach
//usandos biblioteca do Sistema
using System;
//criando minha classe
class Aula22{
    //criando meu metodo principal
    static void Main(){
        //criando vetor
        int[] num= new int[5]{11,22,33,44,55};
        
        /*poderiamos usar o for mais o foreach melhor
        for(int i=0; i<=num.Length-1; i++){
            Console.WriteLine(num[i]);
        }*/
        // loop foreach
        foreach(int n in num){
            Console.WriteLine(n);
        }
    }
}