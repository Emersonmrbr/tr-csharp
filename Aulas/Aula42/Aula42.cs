using System;
class Carro
{
  private int[] velMaxima = new int[5] { 80, 120, 160, 200, 240 };

  public int this[int i]
  {
    get
    {
      return velMaxima[i];
    }
    set
    {
      if (value < 0)
      {
        velMaxima[i] = 0;
      }
      else if (value > 300)
      {
        velMaxima[i] = 300;
      }
      else
      {
        velMaxima[i] = value;

      }
    }
  }
}
class Aula42
{
  static void Main()
  {
    Carro tiida = new Carro();
    tiida[4] = 120;
    Console.WriteLine("Velocidade:{0}", tiida[4]);
  }
}