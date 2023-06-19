//Condicional IF-ELSE
//Usando biblioteca do sistema
using System;
//criando minha classe
class Aula13{
    //criando meu metodo 
    static void Main(){
        //criando minhas variaveis
        int n1,n2,n3,n4,notas;
        string resultado="";
        //setando valor pra não dar erro
        notas=n1=n2=n3=n4=0;

        //Perguntando ao usuario quais a nota 
        Console.WriteLine("Me informe a primeira nota: ");
        n1=int.Parse(Console.ReadLine());

        Console.WriteLine("Me informe a segunda nota: ");
        n2=int.Parse(Console.ReadLine());

        Console.WriteLine("Me informe a terceira nota: ");
        n3=int.Parse(Console.ReadLine());

        Console.WriteLine("Me informe a quarta nota: ");
        n4= int.Parse(Console.ReadLine());

        //somando as notas
        notas=n1+n2+n3+n4;

        //criando estrutura para ver se foi reprovrado,recuperação ou aprovado

        if(notas<=40){
           resultado="Reprovado"; 
        }
        else if (notas > 40 & notas <60)
        {
            resultado="Recuperação";

        }else if(notas >= 60){

            resultado="Aprovado";
        }

        Console.WriteLine(resultado);

    }
}