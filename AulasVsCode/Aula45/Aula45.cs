using System;

struct Carro
{
  public string modelo;
  public string cor;

  public void info()
  {
    Console.WriteLine("Modelo: {0}", this.modelo);
    Console.WriteLine("Cor...: {0}", this.cor);
    Console.WriteLine("-------------------");
  }
}
class Aula45
{
  static void Main()
  {
    Carro[] carros = new Carro[4];
    carros[0].cor = "Prata";
    carros[0].modelo = "CRV";
    carros[1].cor = "Preto";
    carros[1].modelo = "Lancer";
    carros[2].cor = "Azul";
    carros[2].modelo = "Imprenzza";
    carros[3].cor = "Vermelho";
    carros[3].modelo = "GTR";
    for (int i = 0; i < carros.Length; i++)
    {
      carros[i].info();
    }
  }
}