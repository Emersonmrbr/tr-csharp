using System;

class Veiculo
{ //Classe pai
  private int rodas;
  public int velMax;
  private bool ligado;

  public Veiculo(int rodas)
  {
    this.rodas = rodas;
  }
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
    return (ligado ? "sim" : "não");
  }
  public int getRodas()
  {
    return rodas;
  }
  public void setRodas(int rodas)
  {
    if (rodas < 0)
    {
      this.rodas = 0;
    }
    else if (rodas > 40)
    {
      this.rodas = 40;
    }
    else
    {
      this.rodas = rodas;
    }
  }
}
class Carro : Veiculo
{ //Classe derivada
  public string nome;
  public string cor;
  public Carro(string nome, string cor) : base(4)
  {
    desligar();
    velMax = 120;
    this.nome = nome;
    this.cor = cor;
  }
}
class Aula35
{
  static void Main()
  {
    Carro c1 = new Carro("Tiida", "Prata");
    c1.ligar();
    Console.WriteLine("Cor..............: {0}", c1.cor);
    Console.WriteLine("Nome.............: {0}", c1.nome);
    Console.WriteLine("Rodas............: {0}", c1.getRodas());
    Console.WriteLine("Velocidade Máxima: {0}", c1.velMax);
    Console.WriteLine("Ligado...........: {0}", c1.getLigado());
    Console.WriteLine("-----------------------------------");
    CarroCombate cc1 = new CarroCombate();
    cc1.desligar();
    Console.WriteLine("Cor..............: {0}", cc1.cor);
    Console.WriteLine("Nome.............: {0}", cc1.nome);
    Console.WriteLine("Rodas............: {0}", cc1.getRodas());
    Console.WriteLine("Velocidade Máxima: {0}", cc1.velMax);
    Console.WriteLine("Ligado...........: {0}", cc1.getLigado());
    Console.WriteLine("-----------------------------------");
  }
}
class CarroCombate : Carro
{
  public int municao;
  public CarroCombate() : base("Carro de combate", "Verde")
  {
    municao = 100;
    setRodas(6);
  }
}