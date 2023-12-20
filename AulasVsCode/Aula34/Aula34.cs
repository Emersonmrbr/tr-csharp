using System;

class Veiculo
{ //Classe pai
  public int velMax;
  private bool ligado;
  public int rodas;
  public void ligar()
  {
    ligado = true;
  }
  public void desligar()
  {
    ligado = false;
  }
  public string getLigado()
  {
    if (ligado)
    {
      return "sim";
    }
    else
    {
      return "não";
    }
  }
}
class Carro : Veiculo //Classe derivada
{
  public string nome;
  public string cor;
  public Carro(string nome, string cor)
  {
    desligar();
    rodas = 4;
    velMax = 120;
    this.nome = nome;
    this.cor = cor;
  }
}
class Aula34
{
  static void Main()
  {
    Carro c1 = new Carro("Tiida", "Prata");
    Console.WriteLine("Cor..............................: {0}", c1.cor);
    Console.WriteLine("Nome.........................: {0}", c1.nome);
    Console.WriteLine("Rodas.........................: {0}", c1.rodas);
    Console.WriteLine("Velocidade Máxima: {0}", c1.velMax);
    Console.WriteLine("Ligado........................: {0}", c1.getLigado());
  }
}