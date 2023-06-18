//Conversões de Tipo
//usando biblioteca do Sistema
using System;
//criando classe
class aula11{
    //cariando metodo Principal
    static void Main(){
        //cariando variaveis
        float n1=10.5f;
        int n2=(int)n1; //operação de conversão TYPECAST
        //exibindo resultado
        Console.WriteLine(n2);

        //exemplo 2
        //criando variavel
        int valor=10;
        short vshort=(short)valor;//convertendo operação de TYPECAST
        //exibindo resultado
        Console.WriteLine(vshort);
    }
}