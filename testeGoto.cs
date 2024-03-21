using System;

class Program
{
    static void Main(){
        
        int tempo = 0;
        char escolha;

        inicio:

        Console.Clear();

        Console.WriteLine("Recife - João Pessoa");
        Console.WriteLine("Ecolha o meio de transpote([a] avião/ [c] carro / [o] onibus): ");

        escolha = char.Parse(Console.ReadLine());


        switch (escolha){

            case 'a':
            case 'A':
                tempo = 45;
                break;
            case 'c':
            case 'C':
                tempo = 130;
                break;
            case 'o':
            case 'O':
                tempo = 2400;
                break;
            default:
            tempo = -1;
            break;
        }

    if(tempo <0){
        Console.WriteLine("Tempo indisponivel!");
    }else
    {
        Console.WriteLine("Levara {0} para chegar la", tempo);
    }
    
    Console.WriteLine("Calcular de novo?[s/n]");
    escolha = char.Parse(Console.ReadLine());

    if(escolha == 's' || escolha =='S'){
        goto inicio;
    }else{
        Console.Clear();
        Console.WriteLine("Fim do prog");
    }
    Console.ReadKey();
    }
}