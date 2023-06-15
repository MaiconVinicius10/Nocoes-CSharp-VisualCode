// operações de Bitwise 
// << vai dobrar o valor deslocar  bits para a esquerda
// >> vai diminuir pra metade o valor deslocar  bits para direita 
//usando biblioteca do sistema
using System;
//criando classe 
class Aula09{
    //criando metodo 
    static void Main(){
        //criando variavel
        int num=10;
        //operação para dobrar
        num=num<<1;
        //exibindo resultado
        Console.WriteLine(num);


        //criando variavel
        int num2=10;
        //operação para metada duas vezes
        num2=num2>>2;
        //exibindo resultado
        Console.WriteLine(num2);

    }
}