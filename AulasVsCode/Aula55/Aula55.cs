using System;
using System.Collections.Generic;
class Aula55
{
  static void Main()
  {
    Dictionary<int, string> veiculos = new Dictionary<int, string>();
    veiculos.Add(50, "Aviao");
    veiculos.Add(40, "Carro");
    veiculos.Add(30, "Moto");
    veiculos.Add(20, "Bicicleta");
    veiculos.Add(10, "Skate");

    // veiculos.Clear();
    veiculos.Remove(20);
    System.Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
    int chave = 20;
    if (veiculos.ContainsKey(chave))
    {
      System.Console.WriteLine("A chave {0} está na coleção", chave);
    }
    else
    {
      System.Console.WriteLine("A chave {0} não está na coleção", chave);

    }
    veiculos[50] = "Navio";
    string valor = "Navio";
    if (veiculos.ContainsValue(valor))
    {
      System.Console.WriteLine("O valor {0} está na coleção", valor);
    }
    else
    {
      System.Console.WriteLine("O valor {0} não está na coleção", valor);

    }
    // Metodo 1
    foreach (KeyValuePair<int, string> v in veiculos)
    {
      System.Console.WriteLine(v.Key);
    }
    // Metodo 2
    Dictionary<int, string>.ValueCollection valores = veiculos.Values;
    foreach (string v in valores)
    {
      System.Console.WriteLine(v);
    }
  }
}