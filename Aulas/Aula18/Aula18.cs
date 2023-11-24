using System;
class Aula18
{
  public static void Main()
  {
    int[,] n = new int[3, 5];
    int[,] num = new int[2, 2] { { 10, 20 }, { 30, 40 } };
    n[0, 0] = 10; n[0, 1] = 20; n[0, 2] = 30; n[0, 3] = 40; n[0, 4] = 50;
    n[1, 0] = 60; n[1, 1] = 70; n[1, 2] = 80; n[1, 3] = 90; n[1, 4] = 100;
    n[2, 0] = 5; n[2, 1] = 15; n[2, 2] = 25; n[2, 3] = 35; n[2, 4] = 45;


    Console.WriteLine(n[1, 4]);
  }
}