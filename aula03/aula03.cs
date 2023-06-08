// aprendendo sobre variaveis
//usando biblioteca
using System;
// criando classe
class Aula03{
    // criando meu metodo principal
    static void Main(){
        // variaveis
        // inteiro de 8 bis
        byte n1=10; // 0 e 255
        // inteiro
        int num=0;
        //char caracter 1 caracter
        char letra ='c';
        //variaveis floats valore reais
        float valor = 5.3f;
        // string conjunto de caracteres
        string nome = "Bruno";
        // var não esta especificando o tipo
        var aux=10;
        // como ler uma variavel
        Console.WriteLine("Valor da variavel:"+aux+".....");

        // como declarar multi variaveis
        int num1,num2,res;

        num1=10;
        num2=10;
        res=num1*num2;

        Console.WriteLine("A multiplicação: "+num1 + " com "+num2+" é: "+res);

    }
}