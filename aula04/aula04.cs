//aprendendo sobre escopo de variavel
// usando biblioteca do sistema
using System;
// criando classe
class Aula4{
    // criando variavel global , criar ela dentro da classe antes dos metodos
    static int num=101;

    // criando meu metodo main
    static void Main(){
        //criando variavel num que é local , só consigo usar dentro do main
        int num1=10;
        // exibindo variavel global
        Console.WriteLine(num);
    }

    
}