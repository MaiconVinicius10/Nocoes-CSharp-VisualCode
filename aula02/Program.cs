//aprendendo a criar programa no padrão dotnet 
// e utilizar o args
// 1-)comando no terminal: dotnet new console
//usando a biblioteca do sistema
using System;
//criando namespace de organização
namespace Aula02
{
    //crriando classe
    class Program
    {
        //criando metodo principall
        static void Main(string[] args)
        {
            //exibindo olá mundo
            Console.WriteLine("Hello Word!!!");
            //se digitar algo entra no if
            if (args.GetLength(0) > 0)
            {   
                Console.Write("Você digitou: {0}",args.GetValue(0));
            }

        }
    }
}