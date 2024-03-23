using System;
class Program{
    static void Main(){
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11, 22, 33, 44, 55}, {66, 77, 88, 99, 00}};

        //gerar num aleatorio
        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++){
            vetor1[i] = random.Next(51);
        }
        Console.WriteLine("Elementos dos vetor1: ");
        foreach (int n in vetor1){
            Console.WriteLine(n);
        }

        //procurar num
        //public static int BinarySearch(array, valor);
        Console.WriteLine("BinarySearch");
        int procurando = 3;
        int pos = Array.BinarySearch(vetor1, procurando);
        Console.WriteLine("Valor {0} está na posição: {1}", procurando, pos);
        Console.WriteLine("--------------------------------------------------------------------");

        //copiar array inteiro ou uma certa qntd
        //public static void Copy(Ar_origem, Ar_destino, qtde_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length); 
        foreach (int m in vetor2){
            Console.WriteLine(m);
        }
        Console.WriteLine("--------------------------------------------------------------------");

        //copiar array a partir de certa posição
        //public void CopyTo(Ar_origem,Ar_destino,a_partir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach (int b in vetor3){
            Console.WriteLine(b);
        }
        Console.WriteLine("--------------------------------------------------------------------");

        //public long GetLongLength(dimensão);
        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos: {0}", qtdeElementosVetor);
        Console.WriteLine("--------------------------------------------------------------------");

        //public int GetLowerBound(dimensão);
        Console.WriteLine("GetLowerBound");
        int menorIndiceVetor = vetor1.GetLowerBound(0);
        int menorIndiceMatriz = matriz.GetLowerBound(1);
        Console.WriteLine("Menor Indice do vetor: {0}", menorIndiceVetor);
        Console.WriteLine("Menor Indice da matriz: {0}",menorIndiceMatriz);
        Console.WriteLine("--------------------------------------------------------------------");

        //public int GetUpperBound(dimensão);
        Console.WriteLine("GetUpperBound");
        int maiorIndiceVetor = vetor1.GetUpperBound(0);
        int maiorIndiceMatriz = matriz.GetUpperBound(1);
        Console.WriteLine("Maior indice do vetor: {0}", maiorIndiceVetor);
        Console.WriteLine("Maior indice da matriz: {0}", maiorIndiceMatriz);
        Console.WriteLine("--------------------------------------------------------------------");

        // public object GetValue(dimensão);
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor na posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("Valor na posição 1x3 da matriz: {0}", valor1);
        Console.WriteLine("--------------------------------------------------------------------");

        //public static int IndexOf(Array, valor);
        Console.WriteLine("IndexOf");
        int indice0 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice0);
        Console.WriteLine("--------------------------------------------------------------------");

        //public static int LastIndexOf(Array, valor);
        Console.WriteLine("LatIndexOf");
        int indice1 = Array.LastIndexOf(vetor1,3);
        Console.WriteLine("Indice do ultimo valor 3: {0}", indice1);
        Console.WriteLine("--------------------------------------------------------------------");

        //public static void Reverse(vetor);
        Console.WriteLine("Reverse");
        Array.Reverse(vetor3);
        foreach (int n in vetor3){
            Console.WriteLine(n);
        }
        Console.WriteLine("--------------------------------------------------------------------");

        //public void SetValue(object valor, long pos);
        Console.WriteLine("SetValue");
        vetor2.SetValue(99, 0);
        for (int i = 0; i < vetor2.Length; i++){
            vetor2.SetValue(0,i);
        }
        Console.WriteLine("Vetor 2: ");
        foreach (int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("--------------------------------------------------------------------");

        //public static void Sort(array);
        Console.WriteLine("Sort");
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor 1: ");
        foreach (int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("Vetor 2: ");
        foreach (int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("Vetor 3: ");
        foreach (int n in vetor3){
            Console.WriteLine(n);
        }
        Console.ReadKey();
    }
}