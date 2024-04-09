using System;

static public class Jogador{
    static public int energia;
    static public bool vivo;
    static public string nome;
    static public void iniciar (string n){
        energia = 100;
        vivo = true;
        nome = n;
    }
    static public void info(){
        Console.WriteLine("NOME JOGADOR......: {0}", nome);
        Console.WriteLine("ENERGIA DO JOGADOR: {0}", energia);
        Console.WriteLine("STATUS DO JOGADOR.: {0}\n", vivo);
    }
}

class Inimigo{
    static public bool alerta;
    public string nome;

    public Inimigo(string n){
        alerta = false;
        nome = n;
    }

    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine();
    }
}
class Program{

    static void Main(){

        Jogador.iniciar("Liars");
        Jogador.info();

        Inimigo i1 = new Inimigo("Mona");
        Inimigo i2 = new Inimigo("CeCe");
        Inimigo i3 = new Inimigo("Alex");

        Inimigo.alerta = true;
        i1.info();
        i2.info();
        i3.info();

        Console.ReadKey();
        
    }

}