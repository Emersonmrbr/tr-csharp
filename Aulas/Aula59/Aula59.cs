using System;
using System.Collections.Generic;

class Aula59
{
  static void Main()
  {
    Queue<string> veiculos = new Queue<string>();
    veiculos.Enqueue("Moto");
    veiculos.Enqueue("Carro");
    veiculos.Enqueue("Navio");
    veiculos.Enqueue("Aviao");
    System.Console.WriteLine("Tamanho fila " + veiculos.Count);
    string v = "Skate";
    if (veiculos.Contains(v))
    {
      System.Console.WriteLine("Veiculos " + v + " encontrado");
    }
    else
    {
      System.Console.WriteLine("Veiculos " + v + " não encontrado");
    }
    // veiculos.Clear();
    // System.Console.WriteLine("Primeiro veiculo " + veiculos.Dequeue());
    // System.Console.WriteLine("Primeiro veiculo " + veiculos.Dequeue());
    // System.Console.WriteLine("Primeiro veiculo " + veiculos.Peek());
    // foreach (string i in veiculos)
    // {
    //   System.Console.WriteLine("Veiculo " + i);
    //   System.Console.WriteLine(veiculos.Dequeue());
    // }
    while (veiculos.Count > 0)
    {
      System.Console.WriteLine(veiculos.Dequeue());
    }
    System.Console.WriteLine("Tamanho fila " + veiculos.Count);
  }
}