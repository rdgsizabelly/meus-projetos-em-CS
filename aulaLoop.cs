using System;

class Program{

    static void Main(){
    
    // int a, i = 0;
    // int[] num= new int[10];

    // a =  int.Parse(Console.ReadLine());
    
    // while (i< num.Length)
    // {
    //     num[i] = a + i;
    //     Console.WriteLine(num[i]);
    //     i++;
    // }
    
    // for (int i = 0; i < num.Length; i++)
    // {
    //     num[i] = a + i;
    //     Console.WriteLine("num: {0} na pos: {1}", num[i], i);
    // }

    // int[,] matriz = new int[,]
    // {
    //     {1, 2, 3},
    //     {4, 5, 6},
    //     {7, 8, 9}
    // };

    // int linhas = matriz.GetLength(0);
    // int colunas = matriz.GetLength(1);

    // for (int i = 0; i < linhas ; i++)
    // {
    //     for (int j = 0; j < colunas; j++)
    //     {
    //         Console.WriteLine("Elemento na pos: {0} {1}: {2}", i, j, matriz[i,j]);
    //     }
    // }

    // int a;
    // int[,] matriz = new int[10,2];

    // Console.WriteLine("Digite um numero: ");
    // a = int.Parse(Console.ReadLine());

    // for (int i = 0; i < 10; i++)
    // {
    //     matriz[i, 0] = i + 1;
    //     matriz[i, 1] = a * (i +1);
    // }
    // Console.WriteLine("Tabuada do numero: ", a);

    // for (int i = 0; i < 10; i++)
    // {
    //     Console.WriteLine("{0} x {1} = {2}", matriz[i, 0], a, matriz[i,1]);
    // }

    //string senha = "123";
    //string senhauser;
    //int tentativas = 0;

    // do
    // {
    //     Console.Clear();
    //     Console.WriteLine("Digite a senha: ");
    //     senhauser = Console.ReadLine();
    //     tentativas++;
    // } while (senha != senhauser);

    // Console.WriteLine("Senha correta! Tentativas: {0}", tentativas);

    int[] num = new int[3]{11, 22, 33};

    foreach (int n in num)
    {
        Console.WriteLine(n);
    }
     Console.ReadKey();
    }

}