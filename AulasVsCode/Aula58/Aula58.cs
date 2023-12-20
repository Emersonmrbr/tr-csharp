using System;
using System.Collections.Generic;
class Aula57
{
  static void Main()
  {
    List<string> carros1 = new List<string>();
    // List<string> carros2 = new List<string>();
    string[] carros3 = new string[20];
    carros1.Add("GTR");
    carros1.Add("Imprenza");
    carros1.Add("Lancer");
    carros1.Add("HRV");
    carros1.Add("HRV");
    // carros2.AddRange(carros1);
    // carros2.Clear();
    if (carros1.Contains("Golf"))
    {
      System.Console.WriteLine("Carro encontrado");
    }
    else
    {
      System.Console.WriteLine("Carro não encontrado");

    }
    carros1.Insert(1, "X5");
    // carros1.Reverse();
    carros1.Sort();
    System.Console.WriteLine("Tamnho: {0}", carros1.Count);
    carros1.Capacity = 15;
    System.Console.WriteLine("Capacidade: {0}", carros1.Capacity);
    // carros1.RemoveAt(4);
    // if (carros1.Remove("HRV"))
    // {
    //   System.Console.WriteLine("Carro removido");
    // }
    // else
    // {
    //   System.Console.WriteLine("Carro NÃO removido");
    // }
    int iC1 = carros1.LastIndexOf("HRV");

    foreach (string c1 in carros1)
    {
      System.Console.WriteLine("Carro1: {0}", c1);
    }
    System.Console.WriteLine("A posição do último HRV é: {0}", iC1);

    // Sobrecargas
    // CopyTo(T[], Int32)
    // Copia todo o List<T> para uma matriz unidimensional compatível, iniciando no índice especificado da matriz de destino.
    // CopyTo(Int32, T[], Int32, Int32)
    // Copia um intervalo de elementos do List<T> para uma matriz unidimensional compatível, começando pelo índice especificado da matriz de destino.
    // CopyTo(T[])
    // Copia todo o List<T> em uma matriz unidimensional compatível, a partir do início da matriz de destino.

    // O exemplo a seguir demonstra todas as três sobrecargas do CopyTo método. Uma List<T> das cadeias de caracteres é criada e populada com 5 cadeias de caracteres. Uma matriz de cadeia de caracteres vazia de 15 elementos é criada e a sobrecarga do CopyTo(T[]) método é usada para copiar todos os elementos da lista para a matriz começando no primeiro elemento da matriz. A CopyTo(T[], Int32) sobrecarga do método é usada para copiar todos os elementos da lista para a matriz começando no índice de matriz 6 (deixando o índice 5 vazio). Por fim, a sobrecarga do CopyTo(Int32, T[], Int32, Int32) método é usada para copiar três elementos da lista, começando com o índice 2, para a matriz começando no índice de matriz 12 (deixando o índice 11 vazio). Em seguida, o conteúdo da matriz é exibido.
    carros1.CopyTo(1, carros3, 5, 2);
    foreach (string c3 in carros3)
    {
      System.Console.WriteLine("Carro2: {0}", c3);
    }
    string car1 = "HRV";
    int pos = 0;
    pos = carros1.IndexOf(car1);
    System.Console.WriteLine("Carro {0} está na posição {1}", car1, pos);
  }
}