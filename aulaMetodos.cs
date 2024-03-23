using System;

class Program{

    static void Main(){
        //metodo com retorno 
         int v1, v2, r;
         v1 = int.Parse(Console.ReadLine());
         v2 = int.Parse(Console.ReadLine());
         r = soma(v1, v2);
         Console.WriteLine("A soma de {0} e {1} é igual a: {2}", v1, v2, r);
         //soma(v1, v2);

        //metodo passagem por ref e valor
         int num = 10;
         dobrar( ref num);
         Console.WriteLine(num);

        //argumento out para retornar mais de um resultado
        int divid, divis, quoc, rest;
        divid = 10;
        divis = 5;
        quoc= D1 (divid, divis, out rest);
        Console.WriteLine("{0} / {1} = {2} e o resto = {3}", divid, divis, quoc, rest);

        soma2(23, 32);
        Console.ReadKey();
    }

    //metodo com retorno
     static int soma(int n1, int n2){
         int result = n1 + n2;
       //Console.WriteLine("A soma de {0} e {1} é igual a: {2}", n1, n2, result);
        return result;
     }

    //metodo passagem por ref e por valor
     static void dobrar(ref int valor){

         valor *= 2;
     }

    //argumento out para retornar mais de um resultado
    static int D1(int dividendo, int divisor, out int resto){
        int quociente;
        quociente= dividendo/divisor;
        resto= dividendo%divisor;
        return quociente;

    }

    //argumento params para criar argumentos sem precisar declarar
    static void soma2(params int[] n){
        int rest=0;

        if(n.Length < 1){
            Console.WriteLine("Não existem numero sufucientes");
        }else if(n.Length < 2){
            Console.WriteLine("Somente um numero informado. num: {0}", n[0]);
        }else{
            for (int i = 0; i < n.Length; i++)
            {
                rest += n[i];
            }
            Console.WriteLine("A soma dos numero é: {0}", rest);
        }
    }

}