//Enumeradores
//usando biblioteca do sistema
using System;
//criando classe 
class Aula10{
    //criando meu enumerador
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado}
    //criando metodo principal
    static void Main(){
        //exemplo1
        //Recebendo valor dentro do enumerador
        DiasSemana ds = DiasSemana.Domingo;
        //exibindo resultado
        Console.WriteLine(ds);

        //Exemplo2
        //queroo acessar um indice
        DiasSemana ds1 = (DiasSemana)3;
        Console.WriteLine(ds1);

        //Exemplo3
        //Associar um valor ao meu tipo, imprimindo valor inteiro
        int ds2=(int)DiasSemana.Sexta;
        Console.WriteLine(ds2);


    }

}