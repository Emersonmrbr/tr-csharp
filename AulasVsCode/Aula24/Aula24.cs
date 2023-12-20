using System;
class Aula24
{
  static void Main()
  {
    // map();
    int v1 = Convert.ToInt32(Console.ReadLine());
    int v2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("A soma de {0} e {1} é = {2}", v1, v2, soma(v1, v2));
  }

  // static void map()
  // {
  //   Console.WriteLine("Núcleo MAP Automação Industrial");
  //   Console.WriteLine("Automação Industrial de verdade");
  //   Console.WriteLine("www.nucleomap.com.br");
  // }

  static int soma(int n1, int n2)
  {
    int r = n1 + n2;
    return r;
  }

  static double nome(int n1, double n2, string texto)
  {
    return n2;
  }
}