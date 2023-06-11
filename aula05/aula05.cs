//Aprendendo sobre OPERADORES e OPERAÇÕES
//Usando biblioteca do sistema
using System;
// criando classe
class Aula05{
    // criando meu metodo principal
    static void Main(){
        //1- criando variavel e adicionando valor nela/// o que esta em parentes calculado primeiro
        int res=(10+5);
        //exibindo resultado
        Console.WriteLine(res);

        //2-operador vedadeiro ou falos 
        bool res1=10<5;   /// operador < menor // operador != diferente // operador 
        //exibindo resultado
        Console.WriteLine(res1);

        //3- formas diferentes de adicionar
        //num++; ou num+=1 ou //num=num+1;  + - / *
        int num = 10;
        num++;
         Console.WriteLine(num);

        //4-) Operador logico  
        //& = AND / E  só retorna se os dois forem verdadeiro
        // | = OR / OU só retorna verdadeiro se um dos resultados for verdadeiro
        bool res2=(5>3)| (10<5);
        Console.WriteLine(res2);
        
    }
}