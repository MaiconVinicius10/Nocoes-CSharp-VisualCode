//Enteder sobre aninhamento IF
//Usando biblioteca do sistema
using System;
//criando minha classe
class Aula13
{
    //criando meu metodo 
    static void Main()
    {
        //criando minhas variaveis
        int n1, n2, n3, n4, notas;
        string resultado = "";
        //setando valor pra não dar erro
        notas = n1 = n2 = n3 = n4 = 0;

        //Perguntando ao usuario quais a nota 
        Console.WriteLine("Me informe a primeira nota: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Me informe a segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Me informe a terceira nota: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Me informe a quarta nota: ");
        n4 = int.Parse(Console.ReadLine());

        //somando as notas
        notas = n1 + n2 + n3 + n4;

        //criando estrutura para ver se foi reprovrado,recuperação ou aprovado com aninhamento
        
        if (notas >= 60)
        {
            if (notas >= 90)
            {
                if (notas >= 99)
                {
                    resultado = "Super louvor";
                }
                else
                {
                    resultado = "Aprovado com Louvos";
                }
            }
            else
            {
                resultado = "Aprovado";
            }
        }
        else
        {
            if (notas >= 40)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }
        }
        Console.WriteLine(resultado);

    }
}