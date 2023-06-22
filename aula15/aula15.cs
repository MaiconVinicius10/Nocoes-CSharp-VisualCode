//Switch Case
//usando biblioteca do sistema
using System;
//criando classe
class Aula15
{
    //criando metodo Principal
    static void Main()
    {
        //criando variaveis
        int tempo = 0;
        char escolha =' ';
        //Perguntando e salvando a escolha do usuario.
        Console.WriteLine("Belo Horizonte/MG a Vitoria/ES");
        Console.WriteLine("Escolha o transporte [a]Avião | [c] Carro | [o] Ônibus");
        escolha = char.Parse(Console.ReadLine());
        //abri estrutura switch para ver qual selecionado
        switch (escolha)
        {
            case 'a':
            case 'A':
                tempo = 50;
                break;

            case 'c':
            case 'C':
                tempo = 480;
                break;

            case 'o':
            case 'O':
                tempo = 660;
                break;

            default:
            tempo=-1;
            break;
        }
        if(tempo < 0 ){
            Console.WriteLine("Tranporte Indisponivel");
        }else{
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos",tempo);
        }
    }
}