//Aprender sobre Constantes
//usando biblioteca do sistema
using System;
//criando minha classe Principal
class Principal{
    //criando meu metodo principal
    static void Main(){
        //declarando variavel const ela não pode ser alterada
        const string canal="Canal California";
        const double pi=3.1415;

        //Ao Tentar alterar ira dar erro por isso eu coloquei como comentario
        //Exemplo de alteração tire o barra barra da erro
        //canal="Bruno"; 

        //imprindo variaveis
        Console.WriteLine("Canal {0}\nPi: {1}",canal,pi);
    }
}