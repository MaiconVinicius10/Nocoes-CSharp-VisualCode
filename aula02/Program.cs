//aprendendo criar no terminal - cdaula02 , dps escreve : dotnet new console

//usando biblioteca do sistema
using System;
//namespace forma de organização
namespace Aula02{
    // criando classe program
    class Program{
        // criando meu metodo menu
        static void Main(string[]args){
            //exibindo ola mundo
            Console.WriteLine("Hello World");
            // verificando se foi digitado algo antes da execução
            if(args.GetLength(0)>0){
                //exibindo
                Console.WriteLine(args.GetValue(0));
            }
            
        }
    }
}