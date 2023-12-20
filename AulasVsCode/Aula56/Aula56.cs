using System;
using System.Collections.Generic;
class Aula56
{
  static void Main()
  {
    LinkedList<string> transp = new LinkedList<string>();
    transp.AddFirst("Carro");
    transp.AddFirst("Aviao");
    transp.AddFirst("Navio");
    transp.AddFirst("Moto");
    transp.AddLast("Bicicleta");
    LinkedListNode<string> no;
    no = transp.FindLast("Navio");
    transp.AddAfter(no, "Patinete");
    no = transp.FindLast("Carro");
    transp.AddAfter(no, "Patins");
    // transp.Clear();
    if (transp.Find("Carro") == null)
    {
      System.Console.WriteLine("Não encontrado");
    }
    else
    {
      System.Console.WriteLine("Elemento encontrado");
    }
    // transp.Remove("Navio");
    transp.RemoveLast();
    transp.RemoveFirst();
    foreach (string t in transp)
    {
      System.Console.WriteLine("Transporte: {0}", t);
    }
  }
}