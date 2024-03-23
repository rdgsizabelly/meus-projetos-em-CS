using System;

class Program{

    static void Main(){

        int a;
        int[] n = new int[5];
        int[,] num = new int[2,2],
        string[] vei = new string[3];

        vei[0] = "carroça";
        vei[1] = "carrinho de mão";
        vei[2] = "escada";

        Console.WriteLine(vei[0]); 
        num[0,0] = 1;
        num[0,1] = 2;
        num[1,0] = 3;
        num[1,1] = 4;
        // n[0] = 12;
        // n[1] = 41;
        // n[2] = 14;
        // n[3] = 13;
        // n[4] = 31;

        a = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 5; i++)
        {
            n[i] = a + i;
            Console.WriteLine(n[i]);
        }

        Console.ReadKey();
    }

}