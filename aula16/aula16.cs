//Comando Goto
//usando biblioteca do sistema
using System;
//criando classe
class Aula16
{
    //criando metodo Principal
    static void Main()
    {
        //criando variaveis
        int tempo = 0;
        char escolha =' ';

        //iniciando a label do goto
        inicio: 
        //limpando o console
        Console.Clear();

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
        //verificando se o tempo é menor que 0
        if(tempo < 0 ){
            Console.WriteLine("Tranporte Indisponivel");
        }else{
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos",tempo);
        }
        //Perguntando ao usuario se quer continuar
        Console.WriteLine("Calcular outro transporte? [s/n]");
        escolha=char.Parse(Console.ReadLine());
        //se quiser cotinuar irei usar goto pra voltar no inicio
        if(escolha=='s' || escolha=='S'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("Fim do Programa");
        }
    }
}