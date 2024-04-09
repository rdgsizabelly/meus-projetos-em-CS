using System;

public class Jogador{
   public int energia;
    public bool vivo;
    public string nome;
    public Jogador(){
        energia = 100;
        vivo = true;
        nome = "Theo";
    }
    public Jogador(string nome){
        energia = 23;
        vivo = true;
        this.nome = nome;
    }
    public Jogador(string nome, int energia){
        this.energia = e;
        vivo = true;
        this.nome = n;
    }
    public Jogador(string nome, int energia, bool vivo){
        this.energia = e;
        this.vivo = v;
        this.nome = n;
    }
    public void info(){
        Console.WriteLine("NOME JOGADOR......: {0}", nome);
        Console.WriteLine("ENERGIA DO JOGADOR: {0}", energia);
        Console.WriteLine("STATUS DO JOGADOR.: {0}\n", vivo);
    }
}
class Program{
    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Joao");
        Jogador j3 = new Jogador("Jose", 45);
        Jogador j4 = new Jogador("Rorbesvaldo", 0, false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
        Console.ReadKey();
        
    }

}