//Formatando a saida de Console
// usando a biblioteca do sistema
using System;
//criando minha classe principal
class Aula06{
    //criando meu metodo principal
    static void Main(){
        // criando variaveis
        int n1,n2,n3;
        //setando valores
        n1=10; n2=20; n3=30;
        // o barra n quebra a linha 
        // barra t inseri tabulação
        //exibindo valores // referindo as posições como indices 0 , 1 ,2
        Console.WriteLine("\nn1=\t{0} \nn2=\t{1} \nn3=\t{2}",n1,n2,n3);


        // exemplo 2
        //criando variaveis e setando valores
        double valorCompra=5.50;
        double valorVenda;
        double lucro=0.1;
        string produto="Pastel";
        //calculando meu valor de venda
        valorVenda=valorCompra+(valorCompra*lucro);
        //usando tabulação com espaçamento 15 de tamanho
        Console.WriteLine("Produto......{0,15}",produto);
        //valor monetário de cifrão com espaçamento 15
        Console.WriteLine("Val.Compra....{0,15:c}",valorCompra);
        //colocar porcentagem com espaçamento 15
        Console.WriteLine("Lucro.........{0,15:p}",lucro);
        //colocar porcentagem com espaçamento 15
        Console.WriteLine("ValorVenda....{0,15:c}",valorVenda);
    }
}