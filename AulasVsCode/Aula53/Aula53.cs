using System;
class Area
{
  public static float Quad(float bas, float alt)
  {
    if (bas == 0 || alt == 0)
    {
      throw new Exception("Base ou altura não podem ser igual a 0");
    }
    return bas * alt;
  }
}
class Aula53
{
  static void Main()
  {
    float area = 0;
    try
    {
      area = Area.Quad(10F, 0);
      System.Console.WriteLine("Area do quadrado :{0}", area);
    }
    catch (System.Exception e)
    {
      System.Console.WriteLine("ERRO: {0}", e.Message);
    }
    finally
    {
      System.Console.WriteLine("Fim do processo");
    }
  }
}