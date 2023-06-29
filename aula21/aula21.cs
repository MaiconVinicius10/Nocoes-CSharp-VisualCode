//Do while : ele executa pelo menos uma vez
//usando a biblioteca do sistema
using System;
//criando classe 
class Aula21{
    //criando metodo principal
    static void Main(){
        //criando variavel
        string senha="123";
        string senhauser;
        int tentativas=0;
        //do while eu garanto que vai ser executado pelo menos uma vez
        do{ 
            Console.Clear();
            Console.WriteLine("Digite sua senha:");
            senhauser=Console.ReadLine();
            tentativas++;
        }while(senhauser != senha);

        Console.WriteLine("Senha Correta, tentativas {0}",tentativas);
    }
}