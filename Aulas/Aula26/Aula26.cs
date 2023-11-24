using System;
class Aula26
{
  static void Main()
  {
    int divid, divis, quoc, res;
    divid = 10;
    divis = 3;
    quoc = divide(divid, divis, out res);
    Console.WriteLine("{0}/{1}: quociente = {2} e resto = {3}", divid, divis, quoc, res);

  }

  static int divide(int dividendo, int divisor, out int resto)
  {
    int quociente = dividendo / divisor;
    resto = dividendo % divisor;
    return quociente;

  }
}