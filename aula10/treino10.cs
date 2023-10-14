// enumeradores
//usando biblioteca do sistema 
using System;
//criando enumeradores
enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};
//criando classe
class Aula10{
    //criando metodo principal
    static void Main(){
        //instanciando forma 1//
        //DiasSemana ds = DiasSemana.Domingo;
        //
        //intanciando forma2//
        //DiasSemana ds = (DiasSemana)3;
        //exibindo o resultado do ds

        //intanciando forma 3 estou convertendo pra ter numero
        int ds = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);
    }
}