//Aprendo a ler valores do teclado
//usando biblioteca do sistema
using System;
//criando classe 
class Aula08{
    //criando meu metodo principal
    static void Main(){
        //criando variaveis
        int v1,v2,soma;
        string nome;
        //perguntando e lendo valores do usuario
        Console.Write("Digite seu nome:");
        nome=Console.ReadLine();

        // ao receber dado teclado converter para inteiro
        Console.Write("Digite o prinmeiro valor: ");
        v1=int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        // ao receber dado teclador converter para interio segunda forma de fazer
        v2=Convert.ToInt32(Console.ReadLine());

        //executando operação
        soma=v1+v2;

        //Exibindo Resultados
        Console.WriteLine("Nome digitado: {0} \nA soma de N1: {1} Mais N2: {2} é : {3}",nome,v1,v2,soma);
    }
}