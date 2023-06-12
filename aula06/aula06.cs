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
        //exibindo valores // referindo as posições como indices 0 , 1 ,2
        // o barra ena eel quebra a linha 
        // barra t inseri tabulação

        Console.WriteLine("\nn1=\t{0} \nn2=\t{1} \nn3=\t{2}",n1,n2,n3);


        // exemplo 2
        //criando variaveis
        double valorCompra=5.50;
        double valorVenda;
        double lucro=0.1;
        string produto="Pastel";
        //calculando meu valor de venda
        valorVenda=valorCompra+(valorCompra*lucro);
        //usando tabulação com espaçamento 15 tamanho do espaço
        Console.WriteLine("Produto......{0,15}",produto);
        //valor monetário de cifrão
        Console.WriteLine("Val.Compra....{0,15:c}",valorCompra);
        //colocar porcentagem
        Console.WriteLine("Lucro.........{0,15:p}",lucro);
        //colocar porcentagem
        Console.WriteLine("ValorVenda....{0,15:c}",valorVenda);
    }
}