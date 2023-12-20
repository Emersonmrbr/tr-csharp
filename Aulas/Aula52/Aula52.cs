using System;
class Aula52
{
  static void Main()
  {
    int n1, n2, res;
    res = n1 = n2 = 0;
    n1 = 10;
    n2 = 0;
    try
    {
      res = n1 / n2;
      Console.WriteLine("{0}/{1}={2}", n1, n2, res);
    }
    catch (System.Exception e)
    {
      System.Console.WriteLine("ERRO: {0}", e.Message);
      System.Console.WriteLine("Ex {0}", e);
      System.Console.WriteLine("Type {0}", e.GetType());
      throw;
    }
  }
}