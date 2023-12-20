using System;
class aula20
{
  static void Main()
  {
    // int[] num = new int[10];
    // int i = 0;
    // while (i < 10)
    // {
    //   Console.WriteLine("Map cusos");
    //   i++;
    // }
    // Console.WriteLine("Fim do loop");

    int[] num = new int[10];
    int i = num.Length - 1;
    while (i > 0)
    {
      num[i] = 0;
      Console.WriteLine(num[i]);
      i--;
    }
    Console.WriteLine("Fm do loop");
  }
}