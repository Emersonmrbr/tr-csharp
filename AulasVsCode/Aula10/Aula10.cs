using System;
class Aula10
{
  enum DiasSemana {Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
  public static void Main(){
    // DiasSemana ds = DiasSemana.Domingo;
    // DiasSemana ds =(DiasSemana)4;
    int ds = (int)DiasSemana.Quinta;
    Console.WriteLine(ds);

  }
}