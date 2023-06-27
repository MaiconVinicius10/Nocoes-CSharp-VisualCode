//Loop While / Etrutura de Iteração enquanto
//Usando biblioteca do sistema
using System;
//criando classe
class Aula20{
    //criando meu metodo Principal
    static void Main(){
        int[] num = new int[10];

        //crinado meu loop
        int i=num.Length-1;
        //enquanto / while
        while(i>0){
            num[i]=0;
            Console.WriteLine(num[i]);
            i--;
        }
        Console.WriteLine("Fim do Loop");
    }
}