using System;

public class Jogador
{
  public int energia;
  public bool vivo;
  public string nome;
  public Jogador(string n)
  {
    energia = 100;
    vivo = true;
    nome = n;
  }
  ~Jogador()
  {
    Console.WriteLine("Jogador {0} foi destruido", nome);
  }
}
class Aula29
{
  static void Main()
  {
    string nome;
    Console.WriteLine("Digite o nome do jogador");
    nome = Console.ReadLine();
    Jogador j1 = new Jogador(nome);
    Jogador j2 = new Jogador("Alguém");
    j1.energia = 50;
    Console.WriteLine("O nome do jogador 1 é: {0}", j1.nome);
    Console.WriteLine("O nome do jogador 2 é: {0}", j2.nome);
  }
}