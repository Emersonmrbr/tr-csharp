using System;

struct Carro
{
  public string marca;
  public string modelo;
  public string cor;
  public Carro(string marca, string modelo, string cor)
  {
    this.marca = marca;
    this.modelo = modelo;
    this.cor = cor;
  }
  public void info()
  {
    Console.WriteLine("Marca.: {0}", this.marca);
    Console.WriteLine("Modelo: {0}", this.modelo);
    Console.WriteLine("Cor...: {0}", this.cor);
  }
}
class Aula44
{
  static void Main()
  {
    Carro c1 = new Carro("Honda", "CRV", "Preto");
    Carro c2 = new Carro("Mitsubishi", "Lancer", "Preto");
    c1.info();
    c2.info();
  }
}