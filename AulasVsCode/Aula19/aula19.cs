using System;
class aula19
{
  static void Main()
  {
    // for (int i = 0; i < 10; i++)
    // {
    //   Console.WriteLine("{0} - MAP Cursos", i);
    // }
    // int[] num = new int[10];
    // for (int i = 0; i < 10; i++)
    // {
    //   num[i] = 0;
    // }
    // for (int i = 0; i < 10; i++)
    // {
    //   Console.WriteLine("Valor de num na pos {0}: {1}", i, num[i]);
    // }
    int[] num = new int[5];
    for (int i = 0; i < num.Length; i++)
    {
      num[i] = i * 10;
    }
    for (int i = 0; i < num.Length; i++)
    {
      Console.WriteLine("Valor de num na pos {0}: {1}", i, num[i]);
    }
  }
}