//Comando Condicional IF
//usando Biblioteca do Sistema
using System;
//criando class
class Aula12{
    
    //criando metodo
    static void Main(){
    //criando variaveis
    int n1,n2,n3,n4,media;
    media=n1=n2=n3=n4=0;
    //criando variavel resultado
    string resultado="Reprovado";

    //pedindo notas e salvando nas variaveis
    Console.WriteLine("Por favor me informe a primeira nota:");
    n1=int.Parse(Console.ReadLine());
    Console.WriteLine("Por favor me informe a segunda nota:");
    n2=int.Parse(Console.ReadLine());
    Console.WriteLine("Por favor me informe a terceira nota:");
    n3=int.Parse(Console.ReadLine());
    Console.WriteLine("Por favor me informe a quartafeira nota:");
    n4=int.Parse(Console.ReadLine());   

    media=(n1+n2+n3+n4)/4;
    //verificando se a media foi a cima de 30
    if(media>=7){
        resultado="Aprovado";
    }
    //exibindo o usuario a media
    Console.WriteLine("Media:{0} , Resultado:{1}",media,resultado);
   }
}