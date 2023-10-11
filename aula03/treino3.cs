//aprendo a criar variaveis
//cirando calculo basico
//  primeio usando a biblioteca do sistema
using System;
//cariando minha classe
class Principal{
    //criando meu metodo principal 
    static void Main(){
        // calculando etiquetas sei que a cada rolo tenho 800 etiquetas preciso de 2000, quantos rolos preciso?

        //criando variaveis
        double Etiqueprecisos,RolosPrecisos;
        int EtiquetasPorRolos=800;
        //perguntando ao usario quantas etiquetas ele precisa
        Console.WriteLine("Quantas etiquetas você precisa?");
        Etiqueprecisos=double.Parse(Console.ReadLine());
        //somando
        RolosPrecisos=Etiqueprecisos/EtiquetasPorRolos;
        //exibindo resultado
        Console.WriteLine("Você precisa comprar :{0} Rolos",RolosPrecisos);
    }
}