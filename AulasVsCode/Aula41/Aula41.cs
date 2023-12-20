using System;
class Carro
{
  private int velMaxima;

  public int vm
  {
    get
    {
      return velMaxima;
    }
    set
    {
      if (value < 0)
      {
        velMaxima = 0;
      }
      else if (value > 300)
      {
        velMaxima = 300;
      }
      else
      {
        velMaxima = value;

      }
    }
  }
}
class Aula41
{
  static void Main()
  {
    Carro tiida = new Carro();
    tiida.vm = 120;
    Console.WriteLine("Velocidade:{0}", tiida.vm);
  }
}