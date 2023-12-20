using System;
class Aula25
{
  static void Main()
  {
    int num1 = 50;
    int num2 = 50;
    dobrar1(ref num1);
    dobrar2(num2);
    Console.WriteLine("{0}, {1}", num1, num2);
  }

  static void dobrar1(ref int valor)
  {
    valor *= 2;
  }
  static void dobrar2(int valor)
  {
    valor *= 2;
  }
}