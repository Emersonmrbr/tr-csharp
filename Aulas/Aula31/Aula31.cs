using System;

static public class Jogador
{
  public int energia;
  public bool vivo;
  public string nome;
  void public Jogador(string n)
  {
    energia = 100;
    vivo = true;
    nome = "n";
  }


  static public void info()
  {
    Console.WriteLine("Nome jogador:.. {0}", nome);
    Console.WriteLine("Energia jogador: {0}", energia);
    Console.WriteLine("Estado jogador:.. {0}\n", vivo);
  }
}
class Aula30
{
  static void Main()
  {
    Jogador j1 = new Jogador();
    Jogador j2 = new Jogador("Emerson");
    Jogador j3 = new Jogador("Suellen", 100);
    Jogador j4 = new Jogador("Sofia", 0, true);

    j1.info();
    j2.info();
    j3.info();
    j4.info();
  }
}